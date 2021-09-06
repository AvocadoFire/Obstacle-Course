using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartEnd : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("test");
            GetComponent<AudioSource>().Play();
            StartCoroutine(LoadAgain());
            //SceneManager.LoadScene(0);
        }

        IEnumerator LoadAgain()
        {
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(0);
        }

    }

}
