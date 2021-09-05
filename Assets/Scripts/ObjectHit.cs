using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    
    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("You hit " + gameObject.name);
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
