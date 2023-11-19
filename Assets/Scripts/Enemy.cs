using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class Enemy : GameBehaviour
{
    public static event Action<GameObject> OnEnemyHit = null;
    public static event Action<GameObject> OnEnemyDie = null;

    public EnemyType myType;
    public float moveDistance = 100f;
    public float speed = 10f;

    public int myHealth = 2;
    int maxHealth;
    float baseSpeed = 10f;
    public int myScore;


    public Transform moveToPos;
    

    // Start is called before the first frame update
    void Start()
    {
        switch(myType)
        {
            case EnemyType.Flying:
                speed = baseSpeed * 2;
                myScore = 5;
                moveToPos = _EM.GetRandomAirSpawnPoint();
                break;

            case EnemyType.Ground:
                speed = baseSpeed;
                myScore = 10;
                moveToPos = _EM.GetRandomGroundSpawnPoint();
                break;

        }
        StartCoroutine(Move());
    }


    //public void Hit(int _damage)
    //{
    //    myHealth -= _damage;

    //    _GM.AddScore(myScore);
    //    //GetComponent<Renderer>().material.color = Color.red;

    //    if(myHealth <= 0)
    //    {
    //        Die();
    //    }
    //    else
    //    {
    //        OnEnemyHit?.Invoke(this.gameObject);
         
    //    }
    //}
    
    public void Die()
    {
        OnEnemyDie?.Invoke(this.gameObject);
        StopAllCoroutines();
    }

   

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        //    StopAllCoroutines();

    }

    IEnumerator Move()
    {


        switch (myType)
        {
            case EnemyType.Flying:
                moveToPos = _EM.GetRandomAirSpawnPoint();
                break;

            case EnemyType.Ground:
                moveToPos = _EM.GetRandomGroundSpawnPoint();
                break;

        }



        while (Vector3.Distance(transform.position, moveToPos.position) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, moveToPos.position, Time.deltaTime * speed);
            yield return null;
        }
        yield return new WaitForSeconds(3);
        StartCoroutine(Move());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
            //Hit(1);
        print("hit");
    }
}
