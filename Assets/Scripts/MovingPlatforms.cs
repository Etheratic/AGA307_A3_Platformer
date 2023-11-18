using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingPlatforms : GameBehaviour
{

    public Transform moveToPos;
    public GameObject[] movingPlatforms;

    Transform startPos;
    Transform endPos;
    bool reverse;

    public float platformSpeed = 1f;

   
   

    // Start is called before the first frame update
    void Start()
    {
        SetUpAI();
    }

    void SetUpAI()
    {

        startPos = Instantiate(new GameObject(), transform.position, transform.rotation).transform;
        
        moveToPos = endPos;
        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Move()
    {
        moveToPos = reverse ? startPos : endPos;
        reverse = !reverse;

        while(Vector3.Distance(transform.position, moveToPos.position)>.3)
        {
            transform.position = Vector3.MoveTowards(transform.position, moveToPos.position, Time.deltaTime * platformSpeed);
            yield return null;

        }
        yield return new WaitForSeconds(1);
        StartCoroutine(Move());
        
           
        
    }


}
