using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotScript : MonoBehaviour
{


    public Light SpotLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Player")
        {
            SpotLight.enabled = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.name == "Player")
        {
            SpotLight.enabled = false;
        }
    }
    private void OnTriggerStay(Collider col)
    {
        if(col.name == "Player")
        {
            SpotLight.transform.Rotate(3f, 90, -90);
        }
    }
}
