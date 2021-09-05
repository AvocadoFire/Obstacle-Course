using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float dropTime = 3;

    MeshRenderer meshRenderer;
    Rigidbody rigidbody;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Time.time > dropTime)
        {
            meshRenderer.enabled = false;
            rigidbody.useGravity = false;
        }
        
    }
}
