using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int Score;
    public Text scoreText;
  

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + Score.ToString();
    }
}
