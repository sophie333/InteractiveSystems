using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField]
    private AnimationCurve m_curve;
    private Transform m_transform;

    // Use this for initialization
    void Start () {
        m_transform = transform;
    }
	
	// Update is called once per frame
	void Update () {
        randomMove();
        //animationMove();
        //vectorMove();
    }

    private void randomMove()
    {
        int[] array = { 0, 0, 1, 2, 3 };
        int rndIndex = Random.Range(0, 5);
        int rndNum = array[rndIndex];

        float xVal = 0;
        float zVal = 0;

        //right
        if (rndNum == 0)
        {
            xVal = 0.1f;
        }
        //left
        else if (rndNum == 1)
        {
            xVal = -0.1f;
        }
        //front
        else if (rndNum == 2)
        {
            zVal = 0.1f;
        }
        //back
        else
        {
            zVal = -0.1f;
        }

        m_transform.position += new Vector3(xVal, 0, zVal);
    }

    private void percentageMove()
    {
        float rndNum = Random.Range(0.0f, 1.0f);

        float xVal = 0;
        float zVal = 0;

        //right
        if (rndNum < 0.4f)
        {
            xVal = 0.1f;
        }
        //left
        else if (rndNum < 0.6f)
        {
            xVal = -0.1f;
        }
        //front
        else if (rndNum < 0.8f)
        {
            zVal = 0.1f;
        }
        //back
        else
        {
            zVal = -0.1f;
        }

        m_transform.position += new Vector3(xVal, 0.0f, zVal);
    }

    private void animationMove()
    {
        float rndCurveVal = Random.Range(0.0f, 1.0f);
        float rndNum = m_curve.Evaluate(rndCurveVal);

        float xVal = 0;
        float zVal = 0;

        //right
        if (rndNum < 0.25f)
        {
            xVal = 0.1f;
        }
        //left
        else if (rndNum < 0.5f)
        {
            xVal = -0.1f;
        }
        //front
        else if (rndNum < 0.75f)
        {
            zVal = 0.1f;
        }
        //back
        else
        {
            zVal = -0.1f;
        }

        m_transform.position += new Vector3(xVal, 0.0f, zVal);
    }

    private void vectorMove()
    {
        float xVal = Random.Range(0.0f, 1.0f); ;
        float zVal = Random.Range(0.0f, 1.0f); ;

        m_transform.position += new Vector3(-xVal, 0.0f, zVal);
    }
}
