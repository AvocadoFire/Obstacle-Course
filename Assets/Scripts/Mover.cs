using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xSpeed = 2f;
    [SerializeField] float zSpeed = 2f;

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue * xSpeed * Time.deltaTime, 0, zValue * zSpeed * Time.deltaTime);
    }
}

