using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem blood
    {
        get
        {
            if (cached_blood == null)
            {
                cached_blood = GetComponent<ParticleSystem>();
            }
            return cached_blood;
        }
    }
    private ParticleSystem cached_blood;
    
    

}
