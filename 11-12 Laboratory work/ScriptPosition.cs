using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3  pos = transform.position;
        pos.x += 0.01f;
        pos.y += 0.03f;
        pos.z += 0.02f;
        transform.position = pos;
      
    }
}
