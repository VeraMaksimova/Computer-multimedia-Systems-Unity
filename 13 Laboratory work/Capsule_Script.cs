using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule_Script : MonoBehaviour
{

    /*4.	Добавить для Capsule компоненту Script, в которой обеспечивается движение 
    объекта клавишами клавиа-туры WASD и движениями курсора мыши по горизонтали на 3D
    -сцене в плоскости X-Z с использованием конструкции Input.GetAxis(),
     как это обеспечивалось для куба в работе по Теме 11 и обсуждалось в Лек-ции 11. */
    /*1.	Изменить в предыдущей сцене код для обработки столкновений персонажа с 
    объектами для изменением не просто цвета объекта, а наложения на него текстуры,
     используя для этого обращение к текстуре в виде
    col.gameObject.GetComponent<Renderer>().material.mainTexture


    8.	Добавить в код скрипта для персонажа в метод Update() возможность наложения требуемой текстуры на объект по нажатию на заданную клавишу клавиатуры, используя напрямую обращение к компоненте Ren-derer объекта, например, с именем Cube1 в виде
 	Cube1.gameObject.GetComponent<Renderer>().material.mainTexture
    при этом переменная Cube1 должна быть объявлена как публичная и связана в скрипте с соответствующим объектом на сцене.

    */

    public Texture texture1;
    public Texture texture2;
    public Texture texture3;
    public Texture texture4;
    public Texture texture5;
    public GameObject Cube1;
    public GameObject Cube2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dX = Input.GetAxis("Horizontal");
        float dZ = Input.GetAxis("Vertical");
        dX = dX * 0.01f;
        dZ = dZ * 0.01f;
        transform.Translate(dX, 0, dZ);

        float dXm= Input.GetAxis("Mouse Y");
        float dYm = Input.GetAxis("Mouse X");
        transform.Rotate(dXm, dYm, 0);

        //при инажатии клавиши
         if(Input.GetKey(KeyCode.U)){
            Cube1.GetComponent<Renderer>().material.mainTexture = texture5;
        }
        if(Input.GetKey(KeyCode.K)){
            Cube2.GetComponent<Renderer>().material.mainTexture = texture4;
        }
    }

    void OnCollisionEnter(Collision col){
       
        if(col.gameObject.name == "Cube1"){
            col.gameObject.GetComponent<Renderer>().material.mainTexture = texture1;

        }
         if(col.gameObject.name == "Cube2"){
            col.gameObject.GetComponent<Renderer>().material.mainTexture = texture2;
        }

  }
}



        //цвета
       /* if(col.gameObject.name == "Cube1"){
            col.gameObject.GetComponent<Renderer>().material.mainTexture = texture1;
        }
         if(col.gameObject.name == "Cube2"){
            col.gameObject.GetComponent<Renderer>().material.color = color2;
        }
        */
  