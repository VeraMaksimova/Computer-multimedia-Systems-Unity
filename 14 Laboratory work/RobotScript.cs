using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3  pos = transform.position;
        if(Input.GetKey(KeyCode.RightArrow)){
            pos.x += 0.01f;
            transform.position = pos;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            pos.x -= 0.01f;
            transform.position = pos;
        }
        if(Input.GetKey(KeyCode.RightShift)){
            pos.y += 0.01f;
            transform.position = pos;
        }
        if(Input.GetKey(KeyCode.PageDown)){
            pos.y -= 0.01f;
            transform.position = pos;
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            pos.z += 0.01f;
            transform.position = pos;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            pos.z -= 0.01f;
            transform.position = pos;
        }

        
    }
}
