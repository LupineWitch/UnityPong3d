using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public enum ePlayer
    {
        PlayerRed,
        PlayerBlue
    }

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed;

    public ePlayer Player;

    // Update is called once per frame
    void Update()
    {
        float inputSpeed = 0;

        Debug.Log(Player.ToString());
        inputSpeed = Input.GetAxisRaw(Player.ToString());

        transform.position += new Vector3(0f, 0f, MovementSpeed * inputSpeed * Time.deltaTime);

    }
}
