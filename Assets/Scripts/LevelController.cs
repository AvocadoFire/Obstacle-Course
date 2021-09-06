using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseLabel;

    private void Start()
    {
        winLabel.SetActive(false);
        loseLabel.SetActive(false);
    }

    public void HandleWinCondition()
    {
        
       // winLabel.SetActive(true);
      //  GetComponent<AudioSource>().Play();
    }

    public void HandleLoseCondition()
    {
        //loseLabel.SetActive(true);
        Time.timeScale = 0;
    }

}
