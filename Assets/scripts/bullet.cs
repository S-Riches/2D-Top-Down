using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed;
    public int bulletDamage;
    public float timer;
    private Vector2 target;


    
    

    void Start()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
    }

    void Update()
    {
        timer += 1.0f * Time.deltaTime;

        if(timer >= 4)
        {
            // destroys the game object after 4 seconds
            GameObject.Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, target, bulletSpeed * Time.deltaTime);

        

    }
/*
    void FixedUpdate()
    {
        this.transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);   
    }
    */
    void OnTriggerEnter2D(Collider2D HitInfo)
    {
        
        if(HitInfo.gameObject.tag == "enemy")
        {
            
            HitInfo.gameObject.GetComponent<Enemy>().TakeDamage(bulletDamage);
            Destroy(gameObject);
        }

        
    }
}
