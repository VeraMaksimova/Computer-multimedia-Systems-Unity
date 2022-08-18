using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bew_ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float k = 0;
    void Update()
    {
        transform.Rotate(0, k, 0);
        k = k + 0.0001f;
    }
}
