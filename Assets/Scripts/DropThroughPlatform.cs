using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropThroughPlatform : GameBehaviour
{

    private Collider platform;
    
    void Start()
    {
        platform = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("DropThroughPlatform") && (Input.GetKeyDown(KeyCode.S)))
        {
            StartCoroutine(TurnOff());
           

        }


    }

    IEnumerator TurnOff()
    {

        platform.enabled = !platform.enabled;
        yield return new WaitForSeconds(2);
        platform.enabled = !platform.enabled;
    }
}
