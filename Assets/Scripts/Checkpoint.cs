using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : GameBehaviour
{

    
    public GameObject resetPoint;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)

    {
        resetPoint.transform.position = _PM.gameObject.transform.position;

        //if (gameObject.CompareTag("CheckPointMove"))
            //_CM.CameraMoveUp();

    }


}
