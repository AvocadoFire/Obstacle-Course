using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int counter = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground") { return; }

        if (other.gameObject.tag != "Hit")
        counter ++;
        Debug.Log("You've bumped into something " + counter + " times.");
        other.gameObject.tag = "Hit";
    }


}
