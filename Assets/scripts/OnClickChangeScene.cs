using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class OnClickChangeScene : MonoBehaviour
{
    public string scene;
    public Button button;

    void Start()
    {
        button.onClick.AddListener(switchScene);

    }
    
    void switchScene()
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        score.Score = 0;
    }


}
