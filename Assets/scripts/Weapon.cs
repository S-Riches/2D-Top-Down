using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    public float fireRate = 10;
    public float damage = 15;
    public int clipsize;
    

    float timeUntilFire = 0;
    public float ReloadSpeed = 2.5f;
    float reloadtime;
    public bool CanShoot;
    bool IsReloading;
    bool reloading;


    public Transform firePoint;
    public GameObject bullet;
    public AudioSource gunshotaudio;
    public Text ammoText;
    public AudioSource ReloadSound;
    PlayerHealth PH;

    void Awake()
    {
        PH = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        gunshotaudio = GetComponent<AudioSource>();
        clipsize = 10;
        
            
    }
    void Start()
    {
        ammoText.text = "Ammo : 10";
        if (clipsize > 0)
        {
            CanShoot = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
       

        if(CanShoot && PlayerHealth.player_health >= 1)
        {

            // if the button pressed is fire 1 and 
            if (Input.GetButtonDown("Fire1") && clipsize != 0)
            {
                timeUntilFire = Time.time + fireRate;
                gunshotaudio.Play();
                Shoot();
                clipsize--;
                ammoText.text = "Ammo : " + clipsize.ToString();

            }
        }


        // reloading
        if(clipsize == 0)
        {
            IsReloading = true;
            ReloadSound.Play();
        }

        if (IsReloading)
        {
            CanShoot = false;
            StartCoroutine(Wait());
            
        }
        
      
    }
    
    IEnumerator Wait()
    {
        if(reloading == false)
        {
            if (IsReloading)
            {
                reloading = true;
                
                yield return new WaitForSeconds(1);
                clipsize = 10;
                IsReloading = false;
                
                CanShoot = true;
                reloading = false;
                ammoText.text = "Ammo : 10";
            }

            else
            {

            }
        }
     
    }

    void Shoot()
    {
        gunshotaudio.Play();
        Instantiate(bullet, firePoint.position,firePoint.rotation);
    }

 
}
