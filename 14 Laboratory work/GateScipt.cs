using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScipt : MonoBehaviour
{
  
    public GameObject Cube;
    public GameObject RightGate;
    public GameObject LeftGate;
    
   
    private void Start()
    {
       
    }
    private void OnTriggerEnter(Collider col)
    {
        if(col.name == "Player" || col.name == "Robot" ){
            LeftGate.transform.Rotate(0f, -70f, 0);
            RightGate.transform.Rotate(0f, +70f, 0);
        }
    
    }
    private void OnTriggerExit(Collider col)
    {
        if(col.name == "Player" || col.name == "Robot" ){
            LeftGate.transform.Rotate(0f, +70f, 0);
            RightGate.transform.Rotate(0f, -70f, 0);
        }
    }
  
    private void OnTriggerStay(Collider col)
    {
          if(col.name == "Robot"){
            Cube.transform.Rotate(0,5f,0);
            Cube.transform.RotateAround(Vector3.zero, Vector3.up, 200f * Time.deltaTime);
          
          
        }
    }
}
