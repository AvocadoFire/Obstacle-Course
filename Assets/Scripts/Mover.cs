using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = .01f;
    [SerializeField] float yValue = .01f;
    [SerializeField] float zValue = .01f;
    void Start()
    {
        
    }

    private void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }
}

