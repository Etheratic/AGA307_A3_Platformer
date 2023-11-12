using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : GameBehaviour
{
    public Transform moveToPos;
    public float cameraSpeed = 1;
    public float cameraSpeedMultiplier;
  


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraSpeed += cameraSpeedMultiplier;
        if (Input.GetKeyDown(KeyCode.O))
            {
            CameraMoveUp();
        }
      
           
            
    }

    public void CameraMoveUp()
    {
        StartCoroutine(MoveUp());
    }

    IEnumerator MoveUp()
    {
        while (Vector3.Distance(transform.position, moveToPos.position) > .3f)
        {
            transform.position = Vector3.MoveTowards(transform.position, moveToPos.position, Time.deltaTime * cameraSpeed);
            yield return null;
        }
        yield return new WaitForSeconds(1);
        StartCoroutine(MoveUp());
        
    }


    
}
