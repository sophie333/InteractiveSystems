using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memory : MonoBehaviour {

    private Transform m_transform;
    public GameObject prefab;
    private GameObject[] m_array;

	// Use this for initialization
	void Start () {
        m_transform = transform;
        m_array = new GameObject[1000];

        for (int i = 0; i < m_array.Length; i++)
        {
            GameObject tmpObject = Instantiate(prefab);
            m_array[i] = tmpObject;
            m_array[i].SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
        //OptimisedTransformTest();
        ObjectAllocation();
	}

    private void ObjectAllocation()
    {
        for (int i = 0; i < 10000; i++)
        {
            int j = 1;
            j++;

            int k = j;
            k++;

            ComplexObject tmpObject = new ComplexObject();
        }
    }

    private void InstantiateTest()
    {
        for (int i = 0; i < 10000; i++)
        {
            GameObject tmpObject = Instantiate(prefab);
            tmpObject.transform.position = Vector3.zero;
            Destroy(tmpObject);
        }            
    }

    private void OptimisedInstantiateTest()
    {
        for (int i = 0; i < 10000; i++)
        {
            m_array[i].SetActive(true);
            m_array[i].transform.position = Vector3.zero;
            m_array[i].SetActive(false);
            //or even array of transform
        }
    }

    private void TransformTest()
    {
        for (int i = 0; i < 10000; i++)
        {
            transform.position = Vector3.zero;
        }
    }

    private void OptimisedTransformTest()
    {
        for (int i = 0; i < 10000; i++)
        {
            m_transform.position = Vector3.zero;
        }
    }
}
