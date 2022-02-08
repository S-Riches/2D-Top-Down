using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    // this script will show a arena complete screen when a set score is reached

    private bool won;
    public int maxScore;
    private int currentscore;
    public GameObject winText;
    public string scene;
    public AudioSource winSound;
    public AudioSource mainloop;

    void Update()
    {
        currentscore = score.Score;
        WinLevel(currentscore, maxScore);
        if (won)
        {
            
            Movement.CanMove = false;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(scene, LoadSceneMode.Single);
            }
        }
        
    }


    public void WinLevel(int currentScore, int MaxScore)
    {
        if (currentScore == MaxScore && !won)
        {
            mainloop.Pause();
            winSound.Play();
            won = true;
            winText.SetActive(true);
            
        }

    }
}


