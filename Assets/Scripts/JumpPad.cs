using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : GameBehaviour
{

    public GameObject player;
    public float jumpBoostStrength = 10f;
    private Vector3 velocity;
    public float gravity = -9.81f;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnTriggerEnter(Collider other)
    {
        print("Working :)");
        _PM.Jump(jumpBoostStrength);
    }

        
}
