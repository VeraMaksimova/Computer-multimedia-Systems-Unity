using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_GetAxis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {   
       float dx = Input.GetAxis("Horizontal");
       float dz = Input.GetAxis("Vertical");
       float x = dx * 0.1f;
       float z = dz * 0.1f;
       transform.Translate(x, 0, z);

       float dXm = Input.GetAxis("Mouse Y");
       float dYm = Input.GetAxis("Mouse X");
       dXm = Mathf.Clamp(dXm, -90, 0);
       dYm = Mathf.Clamp(dYm,  -90, 0);
       transform.Rotate(dXm, dYm, 0f);
    }
}
