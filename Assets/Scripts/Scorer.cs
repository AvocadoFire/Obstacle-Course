using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int counter = 0;
    private void OnCollisionEnter(Collision collision)
    {
        counter ++;
        Debug.Log("You've bumped into something " + counter + " times."); 
    }
}
