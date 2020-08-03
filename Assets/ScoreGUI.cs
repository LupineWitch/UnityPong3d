using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreGUI : MonoBehaviour
{
    // Start is called before the first frame update

    public int RedScore = 0;
    public int BlueScore = 0;
    public GUIStyle Style;
    private void OnGUI()
    {
        float Xdim = Screen.width / 2f;
        float YDim = 30f;
        float Width = 300f;
        float Height = 20f;

        GUI.Label(new Rect(Xdim - (Width / 2f), YDim, Width, Height),$"Blue:{BlueScore} Red:{BlueScore}");
    }
}
