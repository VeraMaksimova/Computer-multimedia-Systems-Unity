using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Script : MonoBehaviour
{

    public GameObject ball;
    public AudioClip Explore_Sound;
    public Transform STVOL;
    public float speed = 0.0001f;
    public GameObject Fire;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += transform.TransformDirection(Vector3.back * speed);
 
        
    }

    private void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Finish"){
            Destroy(ball, 1);
            col.gameObject.GetComponent<Renderer>().material.color = Color.red;
              var Explore = Instantiate(Fire);
            Explore.transform.position = col.transform.position;
            Destroy(Explore,1);
           GetComponent<AudioSource>().Play();
        }
        if(col.gameObject.tag == "Player"){
            Destroy(ball, 1);
            col.gameObject.GetComponent<Renderer>().material.color = Color.blue;
            var Explore = Instantiate(Fire);
            Explore.transform.position = col.transform.position;
            Destroy(Explore,1);
               GetComponent<AudioSource>().Play();
        }
        if(col.gameObject.tag == "EditorOnly"){
            Destroy(ball, 1);
            col.gameObject.GetComponent<Renderer>().material.color = Color.green;
            var Explore = Instantiate(Fire);
            Explore.transform.position = col.transform.position;
            Destroy(Explore,1);
            GetComponent<AudioSource>().Play();
          
        }
      
    }
}
