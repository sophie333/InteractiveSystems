using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour {

    public string text = "";
    private int counter = 0;

    private void OnGUI()
    {
        GUI.Label(new Rect(5.0f, 5.0f, 200.0f, 3000.0f), text);
    }

    private void OnTriggerEnter(Collider other)
    {
        CubeController cube = other.GetComponent<CubeController>();

        if(cube)
        {
            counter++;
            text += "\n" + counter + ". place: " + cube.name;
            cube.GetComponent<Rigidbody>().detectCollisions = false;
        }
    }
}
