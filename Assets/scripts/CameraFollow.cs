using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // this sets the cameras pos to the same as the players with an offset
        transform.position = player.transform.position + offset;
    }


    
}
