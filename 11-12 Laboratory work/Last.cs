using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class last : MonoBehaviour
{
    // Start is called before the first frame update
  
  
    public GameObject prefub;
    void Start()
    {
        
    }

   
    
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.U)){
           Vector3 position = new Vector3 (Random.Range(-5f,5f), Random.Range(1f, 10f), Random.Range(1f, 10f));
           Instantiate(prefub, position, Quaternion.identity);
       }
    }
}
