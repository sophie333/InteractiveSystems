using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomInput : MonoBehaviour {

    private void OnGUI()
    {
        GUI.Label(new Rect(5.0f, 5.0f, 200.0f, 30.0f), "Horizontal axis: ");
        GUI.Label(new Rect(150.0f, 5.0f, 200.0f, 30.0f), Input.GetAxis("Horizontal").ToString());

        GUI.Label(new Rect(5.0f, 30.0f, 200.0f, 30.0f), "Vertical axis: ");
        GUI.Label(new Rect(150.0f, 30.0f, 200.0f, 30.0f), Input.GetAxis("Vertical").ToString());
    }
}
