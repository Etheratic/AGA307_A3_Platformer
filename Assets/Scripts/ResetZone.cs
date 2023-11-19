using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetZone : GameBehaviour
{

   
    
    public Rigidbody rb;
    public GameObject resetPoint;
    bool resetting = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resetting == true)
            GetComponent<Collider>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            StartCoroutine(ResetPlayer());
        }

    }

    public IEnumerator ResetPlayer()

    {

        
        //moving the player back to reset point when in contact with the reset zone. 
        resetting = true;
        

        rb.velocity = Vector3.zero;
        Vector3 startPos = transform.position;
        float resetSpeed = 2f;
        var i = 0.0f;
        var rate = 1.0f / resetSpeed;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            transform.position = Vector3.Lerp(startPos, resetPoint.transform.position, i);
            yield return null;
        }
        
        resetting = false;

        GetComponent<CharacterController>().enabled = true;
    }





}

