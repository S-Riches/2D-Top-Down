using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    /// <summary>
	// this file will control the enemies values, movement, animation
	// and the enemies collision checking.
	// i still remember spending hours on this and thinking it was the best code i'd ever written lol
	// i wish 16 year old sam new about regions however hahaha
    /// </summary>

    public Transform playerpos;
    public Transform particlePos;
    public Vector3 PlayerPos;
    public GameObject blood;

    public AudioSource hurtSound;
    private Transform otherEntity;
    public float distance = 50.0f;
    private Transform thisEntity;

    public float enemyAttackDelay = 0.5f;
    public float enemyAttackTimer;
    public float enemy_health;
    public bool istouching;
    public int scoreValue = 10;
    public float enemyspeed = 0.0f;
    public static bool spawn = true;
    public bool canMove = false;
    private bool touching = false;


    public Animator animator;
    BoxCollider2D bc2d;

    void Awake()
    {
        
        animator = GetComponent<Animator>();
        thisEntity = GetComponent<Transform>();
        
        if (spawn)
        {
            animator.SetTrigger("SpawnTrigger");
            animator.ResetTrigger("SpawnTrigger");
            spawn = false;
            canMove = true;
        }
       


        enemy_health = 20;
        playerpos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        particlePos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        bc2d = GetComponent<BoxCollider2D>();

    }

    

    private float touchingtimer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        

        enemyAttackTimer += Time.deltaTime;
        if(PlayerHealth.IsDead)
        {
            animator.SetBool("IsWalking", false);
            
        }
        
        
        if (!PlayerHealth.IsDead)
        {
             touchingtimer = touchingtimer + Time.deltaTime;
             animator.SetBool("IsWalking", true);
            if (canMove)
            {
                transform.position = Vector2.MoveTowards(transform.position, playerpos.position, enemyspeed * Time.deltaTime);
            }
             
        }
        
        if (enemy_health <= 0)
        {
            score.Score += scoreValue;
            Destroy(gameObject);
        }


    }


    void OnTriggerStay2D(Collider2D col)
    {
        PlayerPos = particlePos.position;

        if (col.gameObject.tag == "Player" && PlayerHealth.player_health >= 0 && enemyAttackTimer >= enemyAttackDelay)
        {
            touching = true;
            PlayerHealth.PlayHurtSound(hurtSound);
            enemyAttackTimer = 0.0f;
            GiveDamage(11);
            Instantiate(blood, PlayerPos, Quaternion.identity);
            
           
        }

        else
        {
            touching = false;
        }
        
    }
 

    public static void GiveDamage(int damage)
    {
        PlayerHealth.player_health -= damage;
        
    }

   public void TakeDamage(int damage)
    {
        this.enemyspeed -= 3;
        enemy_health -= damage;
        
       
    }
}
