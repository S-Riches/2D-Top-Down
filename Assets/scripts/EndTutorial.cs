using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTutorial : MonoBehaviour
{
    BoxCollider2D bc;

    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }

    
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
