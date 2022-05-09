using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCloner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject prefab;
    public GameObject clone;

    void Start()
    {
        for (int i = 0; i<3; i++)
        {
            clone = Instantiate(prefab);
            clone.transform.Translate(i, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
