using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Script : MonoBehaviour
{
    float x = 0f;
    public Transform Wall;
    public Light light1;
    public Light light2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider col){
    
    if(col.name == "Tank"){
    x = x + 0.01f;
        Wall.Rotate(0,0,x);
    }
    }
    private void OnTriggerEnter(Collider col)
    {
        if(col.name == "Tank"){
        light1.intensity = 5;
        light2.intensity = 5;
        }
    
    }

    private void OnTriggerExit(Collider col)
    {
        if(col.name == "Tank"){
        light1.intensity = 0;
        light2.intensity = 0;
        }
      
    }
    

    
     


}
