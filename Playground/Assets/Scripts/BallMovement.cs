using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    [SerializeField]
    private GameObject dotPrefab;

    public float force = 30;

    private Transform m_transform;
    private Camera m_cam;
    private GameObject[] m_dotArray;
    private Vector3 m_direction;
    private float m_gravity = 9.81f;
    private Rigidbody m_rbody;

	void Start () {
        m_cam = Camera.main;
        m_transform = transform;
        m_dotArray = new GameObject[10];
        m_rbody = m_transform.GetComponent<Rigidbody>();

        for (int i = 0; i < m_dotArray.Length; i++)
        {
            GameObject tmpObject = Instantiate(dotPrefab);
            m_dotArray[i] = tmpObject;

            m_dotArray[i].SetActive(false);
        }
	}
	
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Vector3 pigPos = m_cam.WorldToScreenPoint(m_transform.position);
            pigPos.z = 0;

            //gives us a vector between mouse and position of pig - normalized extracts the direction
            m_direction = (pigPos - Input.mousePosition).normalized;

            Aim();
        }

        if (Input.GetMouseButtonUp(0))
        {
            m_rbody.AddForce(m_direction * force, ForceMode.Impulse);

            for (int i = 0; i < m_dotArray.Length; i++)
            {
                m_dotArray[i].SetActive(false);
            }
        }
    }

    private void Aim()
    {
        float Sx = m_direction.x * force;
        float Sy = m_direction.y * force;

        for (int i = 0; i < m_dotArray.Length; i++)
        {
            float t = i * 0.1f;

            float dx = Sx * t; //distance from initial point
            float dy = (Sy * t) - (0.5f * m_gravity * t * t);

            m_dotArray[i].transform.position = new Vector3(m_transform.position.x + dx, m_transform.position.y + dy, m_transform.position.z);

            m_dotArray[i].SetActive(true);
        }
    }
}
