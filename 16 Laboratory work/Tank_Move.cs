using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tnk_Move : MonoBehaviour
{


    Transform Bashnya;			   
    Transform STVOL; 		
    float Speed_Of_Tank = 0.1f;  
    float Basnya_rotation_Speed = 1f; 	
    float Min_Pov_Bashnya = -40f;	
    float Max_Pov_Bashnya = 40f;  
    float Pov_f_TANK_SPEED = 0.3f;  
    float Min_STVOL_ROTATION = -20f;
    float MAX_STVO_ROTATION = 20f; 
    



    public AudioSource Move_Sound;
    public AudioSource Rotate_Sound;


    // Start is called before the first frame update
    void Start()
    {
        Bashnya = gameObject.transform.Find("Башня");
        STVOL = Bashnya.transform.Find("Ствол");
        Move_Sound = GetComponent<AudioSource>();
        Rotate_Sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float TowerAngle = Bashnya.localEulerAngles.y;
        if (TowerAngle > 180)
            TowerAngle = -(360 - TowerAngle);
        float BarrelAngle = STVOL.eulerAngles.x;
        if (BarrelAngle > 180){
            BarrelAngle = -(360 - BarrelAngle);
        }
       
        

        float x = Input.GetAxis("Horizontal") * Pov_f_TANK_SPEED;//Horizontal
        float z = Input.GetAxis("Vertical") * Speed_Of_Tank;//Vertical
        if (x != 0){
            transform.Rotate(0f, 0f, x);
           
        }
        

        if (z != 0){
            transform.Translate(-z, 0, 0);
        }

        if(x != 0 || z != 0){
           Move_Sound.Play();
        }

        if(x == 0 || z == 0){
            Move_Sound.Stop();
        }   
        
        float h = Input.GetAxis("Mouse X");
        if (h != 0 && TowerAngle > Min_Pov_Bashnya && TowerAngle < Max_Pov_Bashnya)
        {
            Bashnya.Rotate( 0,0, h * Basnya_rotation_Speed);
            TowerAngle = Bashnya.localEulerAngles.y;
            if (TowerAngle > 180)
                TowerAngle = -(360 - TowerAngle);
            if (TowerAngle > Max_Pov_Bashnya)
                Bashnya.localEulerAngles = new Vector3( Max_Pov_Bashnya - 0.01f, 0, 0f);///Tower.localEulerAngles = new Vector3(.0f, MaxTowerRotation - 0.01f, .0f);
            else if(TowerAngle < Min_Pov_Bashnya)
                Bashnya.localEulerAngles = new Vector3(Min_Pov_Bashnya + 0.01f, 0, 0f);
        }

        float v = Input.GetAxis("Mouse Y");
        if (v != 0 && BarrelAngle > Min_STVOL_ROTATION && BarrelAngle < MAX_STVO_ROTATION)
        { 
            STVOL.Rotate(v * Basnya_rotation_Speed, 0f, 0f);
            BarrelAngle = STVOL.localEulerAngles.x;
            if (BarrelAngle > 180)
                BarrelAngle = -(360 - BarrelAngle);
            if (BarrelAngle > MAX_STVO_ROTATION)
                STVOL.localEulerAngles = new Vector3(-MAX_STVO_ROTATION - 0.01f, 0f, 0f);
            if (BarrelAngle < Min_STVOL_ROTATION)
                STVOL.localEulerAngles = new Vector3(-Min_STVOL_ROTATION + 0.01f, 0f, 0f);
        }

        if (v != 0 || h != 0){
            Rotate_Sound.Play();
        }
        if(v == 0 || h == 0){
             Rotate_Sound.Stop();
        }
    }
}
