using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : GameBehaviour
{
    private GameObject player;
    private Rigidbody rb;
    public float force;
   


    // Start is called before the first frame update
    void Start()
    {

      //destroy this gameObject after 3 sec
        Destroy(this.gameObject, 3);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        TIMER.IncrementTimer(5f);
     
    }




}
