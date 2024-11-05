using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //SerialaizeField is use  to make the field visible in the inspector
    //which is not undated in script which is only for spectating for any changes we needed in script

    //[SerializeField]float  x = 0.0f;
    //[SerializeField]float  y = 0.01f;
    //[SerializeField]float  z = 0.0f;
    [SerializeField]float movespeed =  11f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {       
        MovePlayer();
    }
    
    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game!");
        Debug.Log("Move player with WASD Keys!");
        Debug.Log("Dont hit the border!");
    }

    void MovePlayer()
    {
        //Time.deltaTime for the time taken by character or any onject to increase or decrease there speed
        float  x = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        float  z = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        transform.Translate(x,0,z);
    }
    

}
