using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclehit : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other) 
    {
        
        
            hits++;
            Debug.Log("You Have bumped into a Obstacle this many times:" + hits);
        
        
    }

   
}
