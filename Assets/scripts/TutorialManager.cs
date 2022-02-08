using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex;
    public GameObject spawner;

    void Update()
    {
        // goes through all objects in the array pop ups
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == popUpIndex)
            {
                popUps[i].SetActive(true);
            }
            else
            {
                popUps[i].SetActive(false);
            }
        }

        if (popUpIndex == 0)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                popUpIndex++;

            }
        }
        else if (popUpIndex == 1)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
            {
                popUpIndex++;
            }

        }
        else if (popUpIndex == 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                popUpIndex++;
            }

        }
        else if (popUpIndex == 3)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                popUpIndex++;
            }
        }

        else if(popUpIndex == 4)
        {
            spawner.SetActive(true);
        }

        else if(popUpIndex == 5)
        {
            popUpIndex++;
        }



        
    }
}


