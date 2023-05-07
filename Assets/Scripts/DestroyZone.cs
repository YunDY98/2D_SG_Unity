using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{   //OnCollisionEnter(Collision other)
    //OnTriggerEnter(Collider other)
    private void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.CompareTag("Player"))
        {
            return;
        }
        
       
        Destroy(other.gameObject);
        
    }

  
        
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
