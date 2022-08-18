using System.Collections;
using System.Collections.Generic;
using UnityEngine;






/*3.	Добавить для персонажа (капсулы) новый скрипт,
 в который включить управление движением объек-та мышью и 
 клавишами на основе метода Input.GetAxis() с именными переменными: 
 Horizontal, Ver-tical для клавиш A, D, W, S и Mouse X для курсора мыши
 . При этом используйте метод trans-form.Translate() для перемещения 
 персонажа по горизонтали клавишами и transform.Rotate() для вращения персонажа
 вокруг вертикальной оси мышью, а также домножьте вычисляемые значения для переменных
 перемещения на конструкцию Time.deltaTime для обеспечения плавности управления.*/
public class Person : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal");
        float dz = Input.GetAxis("Vertical");
        float Dmx = Input.GetAxis("Mouse X");
        transform.Rotate(0, Dmx * Time.deltaTime * 400, 0);
        transform.Translate(dx * Time.deltaTime * 5, 0, dz*Time.deltaTime * 5);
    }
}
