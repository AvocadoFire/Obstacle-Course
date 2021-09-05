using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float degreePerSec = 90;
        
    void Update()
    {
         transform.Rotate(0, 0, Time.deltaTime * degreePerSec);
    }
}
