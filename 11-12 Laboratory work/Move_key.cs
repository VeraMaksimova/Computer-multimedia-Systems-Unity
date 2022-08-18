using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_key : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3  pos = transform.position;
        if(Input.GetKey(KeyCode.D)){
            pos.x += 0.01f;
            transform.position = pos;
        }
        if(Input.GetKey(KeyCode.A)){
            pos.x -= 0.01f;
            transform.position = pos;
        }
        if(Input.GetKey(KeyCode.W)){
            pos.y += 0.01f;
            transform.position = pos;
        }
        if(Input.GetKey(KeyCode.S)){
            pos.y -= 0.01f;
            transform.position = pos;
        }
        if(Input.GetKey(KeyCode.Q)){
            pos.z += 0.01f;
            transform.position = pos;
        }
        if(Input.GetKey(KeyCode.E)){
            pos.z -= 0.01f;
            transform.position = pos;
        }
    }
}
