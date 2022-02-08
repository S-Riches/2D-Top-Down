using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspacer : MonoBehaviour
{

    public BoxCollider2D boxCollider2d;
    public Transform Quad;
    public float distance = 2f;
    Transform otherEntity;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider2d = GetComponent<BoxCollider2D>();
    }

    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "enemy")
        {
            otherEntity = col.GetComponent<Transform>();
            Quad.position = (Quad.position - otherEntity.position).normalized * distance + otherEntity.position;
        }

    
    }
}
