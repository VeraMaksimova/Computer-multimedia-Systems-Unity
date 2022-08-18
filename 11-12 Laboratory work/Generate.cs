using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{   
    // Start is called before the first frame update
    public GameObject prefub;
    void Start()
    {  
    }
    
    void Update()
    {
        float minX = 4f;
        float minZ = 4f;
        float maxX = 4f;
        float maxZ = 4f;
        float maxY = 4f;
        float minY = 4f;
        float nX = Random.Range(minX, maxX);
        float nZ = Random.Range(minZ, maxZ);
        float nY = Random.Range(minY, maxY);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject cub = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cub.transform.position = new Vector3(nX, 0, nZ);
            cub.AddComponent<Rigidbody>();

        }

       // if (Input.GetKeyDown(KeyCode.G)){
       //    Vector3 position = new Vector3 (Random.Range(-5f,5f), Random.Range(1f, 10f), Random.Range(1f, 10f));
       //    Instantiate(prefub,position, Quaternion.identity);
       //}
    }
}
