using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public enum ESide
{
    Red,
    Blue
}
public class PointScore : MonoBehaviour
{
   
    public ESide Side;

    public ScoreGUI ScoreBoard;
    private void OnCollisionEnter(Collision collision)
    {
        
        BalInteraction Ball = collision.gameObject.GetComponent<BalInteraction>();
        Ball.transform.position = new Vector3(0f, 1f, 0f);
        Ball.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        switch(Side)
        {
            case ESide.Blue:
                Ball.GetComponent<Rigidbody>().AddForce(-Ball.InitialForce, ForceMode.Impulse);
                ScoreBoard.RedScore += 1;
                break;
            case ESide.Red:
                Ball.GetComponent<Rigidbody>().AddForce(Ball.InitialForce, ForceMode.Impulse);
                ScoreBoard.BlueScore += 1;
                break;

        }
    }

}
