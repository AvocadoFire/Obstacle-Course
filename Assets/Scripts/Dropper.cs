using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float dropTime = 3;

    MeshRenderer meshRenderer;
    Rigidbody myRigidbody;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
        myRigidbody.useGravity = false;
       
    }
    private void Update()
    {
        if (Time.time > dropTime)
        {
            meshRenderer.enabled = true;
            myRigidbody.useGravity = true;
            GetComponent<Dropper>().enabled = false;
        }
    }

}
