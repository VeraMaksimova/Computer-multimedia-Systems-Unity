using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Trigger : MonoBehaviour
{


    
    public GameObject Cylinder;




    public Light PointLight_1;
    public Light PointLight_2;
    public Light PointLight_3;

    private void OnTriggerStay(Collider col)
    {
        PointLight_1.intensity = Random.Range(0f, 1f);

        PointLight_2.intensity = Random.Range(0f, 1f);

        PointLight_3.intensity = Random.Range(0f, 1f);

        Cylinder.transform.Rotate(0, 100*Time.deltaTime, 0);
    }

}
