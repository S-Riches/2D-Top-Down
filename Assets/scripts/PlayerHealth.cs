using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public GameObject Player;
    public GameObject deathtext;
    public static int player_health;
    public Text Health_Text;
    public Animator anim;
    private bool isAlreadyDead;
    public AudioSource Deathsound;
    public AudioSource mainloop;
    public GameObject blood;
   
  
    
    public string Scene;

    public static bool IsDead;

    // Start is called before the first frame update
    void Start()
    {
        
      
        player_health = 100;
        anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if(player_health <= 0 && !IsDead)
        {
            //Debug.Log("DEAD");
            IsDead = true;
            mainloop.Pause();
            Deathsound.Play();
        }

        Health_Text.text = "Health : " + player_health.ToString();
        

        if (IsDead && !isAlreadyDead)
        {
            
            deathtext.SetActive(true);
            Movement.CanMove = false;
            anim.Play("Death");
            
            
            if (Input.GetButtonDown("Jump"))
            {
                
                SceneManager.LoadScene(Scene, LoadSceneMode.Single);
                score.Score = 0;
                Movement.CanMove = true;
                IsDead = false;
                isAlreadyDead = false;
            }
        }

       
    }
    public void TakeDamage(int damage)
    {
       
        player_health -= damage;
    }

    public static void PlayHurtSound(AudioSource hurtSound)
    {
        hurtSound.Play();

    }
 


}
