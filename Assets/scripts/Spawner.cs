using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    /// <summary>
    /// this should spawn more monsters depending on how many i set it
    /// to.
    /// </summary>

    public GameObject Knight;
    public float startTimeBtwKnights;
    private float timeBtwKnights;
    public Animator knightAnim;
    

    public int numberOfKnights;

    // Update is called once per frame
    void Update()
    {
        if ( timeBtwKnights <= 0 && numberOfKnights > 0)
        {
            Instantiate(Knight, transform.position, Quaternion.identity);
            Enemy.spawn = true;
            timeBtwKnights = startTimeBtwKnights;
            numberOfKnights--;
        }
        else
        {
            timeBtwKnights -= Time.deltaTime;
        }

        if(PlayerHealth.player_health <= 0)
        {
            gameObject.SetActive(false);
        }
        
    }
}
