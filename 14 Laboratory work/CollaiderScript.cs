using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollaiderScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Light light;
    private void OnTriggerEnter(Collider col)
    {
        if(col.name == "Player")
        {
            light.enabled = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.name == "Player")
        {
            light.enabled = false;
        }
    }

}
