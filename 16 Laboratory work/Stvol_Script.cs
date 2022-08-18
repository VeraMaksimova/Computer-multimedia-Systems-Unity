using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stvol_Script : MonoBehaviour
{

    
    public GameObject ball;
    public Transform STVOL;
		
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.V)){

            GameObject new_ball = Instantiate(ball);
            new_ball.transform.position = STVOL.transform.position;
       

            Vector3 rotate = STVOL.rotation.eulerAngles; 
            new_ball.transform.rotation = Quaternion.Euler(rotate.x, rotate.y,rotate.z);
         

           
            
        }
    }
}
