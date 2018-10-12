using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {

    private Transform m_cubeTransform; //m = member of this class (private)

	// Use this for initialization
	void Start () {
        m_cubeTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        m_cubeTransform.position = m_cubeTransform.position + this.transform.forward * 0.02f;

    }
}
