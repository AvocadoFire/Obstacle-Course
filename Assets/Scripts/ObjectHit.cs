using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer myRenderer;
    [SerializeField] AudioSource myAudio;

    private void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            myRenderer.material.color = Color.red;
            myAudio.Play();

        }

       if (other.gameObject.tag == "Ground" && tag != "Roller")
        {
            if (!GetComponent<Rigidbody>()) { return; }
            Destroy (GetComponent<Rigidbody>());
        }
    }
}
