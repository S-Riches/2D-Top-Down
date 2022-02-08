using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D Rb2d;
    public Animator anim;
    
    public Transform player;
    public bool IsWalking;
    private bool flipped = false;
    public static bool CanMove;
    public float speed = 0.0f;
    float verticalMove = 0.0f;
    float horizontalMove = 0.0f;
  
    // Start is called before the first frame update
    void Start()
    {
        CanMove = true;
        
        speed = speed;
        anim = GetComponent<Animator>();
        Rb2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalMove = Input.GetAxisRaw("Vertical") * speed;
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

        if (verticalMove <= 0.1f && CanMove)
        {
            IsWalking = true;
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        if(verticalMove >= -0.1f && CanMove)
        {
            IsWalking = true;
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if (horizontalMove <= -0.1f && CanMove)
        {
            flipped = true;
            
            IsWalking = true;
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            
        }

        if (horizontalMove >= 0.1f && CanMove)
        {
            flipped = false;

            IsWalking = true;
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            
        }
        if(horizontalMove == 0.0f && verticalMove == 0.0f)
        {
            IsWalking = false;
        }

        if (IsWalking == true)
        {
            anim.SetBool("IsWalking", true);
        }
        if(IsWalking == false)
        {
            anim.SetBool("IsWalking", false);
        }

        if (flipped)
        {
            transform.localScale = new Vector2(-0.348147f, transform.localScale.y);
            
        }
        if(flipped == false)
        {
            transform.localScale = new Vector2(0.348147f, transform.localScale.y);
        }
        
        

 
        

    }
    
}
