using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlood : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 4f);
        
    }
}
