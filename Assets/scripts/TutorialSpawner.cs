using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialSpawner : MonoBehaviour
{
    /// <summary>
    ///  should spawn a few monsters
    /// </summary>

    public GameObject Knight;

 
    public float startTimeBtwKnights;
    private float timeBtwKnights;

    public int numberOfKnights;



    void Update()
    {
        if(timeBtwKnights <= 0 && numberOfKnights > 0)
        {
            Instantiate(Knight, transform.position, Quaternion.identity);
            timeBtwKnights = startTimeBtwKnights;
            numberOfKnights--;
          
        }
      

        else
        {
            timeBtwKnights -= Time.deltaTime;
        }
        
    }
 
}
