using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory;
    public GameObject firePostion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire112"))
        {
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = firePostion.transform.position;
        }
        
    }
}
