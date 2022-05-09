using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCloner : MonoBehaviour
{
    public GameObject prefabSphere;
    public int cloneAmount;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cloneAmount; i++)
        {
            Instantiate(prefabSphere);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
