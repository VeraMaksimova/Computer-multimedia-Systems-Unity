using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cube_Script : MonoBehaviour, IPointerClickHandler
{
    int forse = 1000;
    public GameObject cube;
   
    public void OnPointerClick(PointerEventData eventData)
    {
        float red = Random.Range(.0f, 1.0f);
        float green = Random.Range(.0f, 1.0f);
        float blue = Random.Range(.0f, 1.0f);
        Color col1 = new Color(red, green, blue);
        gameObject.GetComponent<Renderer>().material.color = col1;


        Vector3 target = eventData.pointerPressRaycast.worldPosition;
        Vector3 colid = Camera.main.transform.position;
        Vector3 distance = target - colid;
        distance = distance.normalized;
        colid = distance * forse;
        gameObject.GetComponent<Rigidbody>().AddForceAtPosition(colid, target);
    }


}