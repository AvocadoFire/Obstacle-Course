using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer myRenderer;
   // Rigidbody myRigidbody;

    private void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        //myRigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            myRenderer.material.color = Color.red;
            gameObject.tag = "Hit";

        }
       if (other.gameObject.tag == "Ground")
        {
            if (!GetComponent<Rigidbody>()) { return; }
            Destroy (GetComponent<Rigidbody>());
        }
    }
}
