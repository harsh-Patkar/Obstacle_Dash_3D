using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigid;
    [SerializeField]float timetowait = 2f;
    void Start()
    {
        //these is cashing  the renderer so we dont have to call it every frame(every time)
       renderer = GetComponent<MeshRenderer>();
       renderer.enabled = false; 

       rigid = GetComponent<Rigidbody>();
       rigid.useGravity = false;        
    }

    
    void Update()
    {
        if(Time.time > timetowait)
        {
            renderer.enabled = true;
            rigid.useGravity = true; 
        }
    }

}