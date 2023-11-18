using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : GameBehaviour


{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter(Collider other)
    {
        _GM.AddCoin();
        Destroy(this.gameObject);


    }

    
    
    
    
}
