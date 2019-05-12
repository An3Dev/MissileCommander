using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour {

    int avgFrameRate;
    public Text display_Text;
    public int targetFrameRate = 60;

    public void Update()
    {

        Application.targetFrameRate = targetFrameRate;
        float current = 0;
        current = Time.frameCount / Time.time;
        avgFrameRate = (int)current;
        //display_Text.text = avgFrameRate.ToString() + " FPS";
        display_Text.text = "";
    }
}
