using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringPoint : GameBehaviour
{

    private GameObject player;
    
   
    public GameObject projectile;

    public float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        
      
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1)
        {
            timer = 0;
            FireProjectile();

        }
    }

    public void FireProjectile()
    {
        Instantiate(projectile, transform.position, transform.rotation);
    }
}
