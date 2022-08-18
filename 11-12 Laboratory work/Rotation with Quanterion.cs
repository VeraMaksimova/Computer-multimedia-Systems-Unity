using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_QUA : MonoBehaviour
{

    Quaternion q = new Quaternion();
    float angle = 0f;
   
    void Start()
    {
        q = transform.rotation;
    }
    // Update is called once per frame
    void Update()
    {
        angle++;
        Quaternion qx = Quaternion.AngleAxis(angle,Vector3.right);
        Quaternion qz = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = q * qx * qz;
    }
}
