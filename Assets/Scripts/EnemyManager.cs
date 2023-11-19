using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum EnemyType
{
    Flying, Ground
}

public class EnemyManager : Singleton<EnemyManager>
{

    public Transform[] spawnPoints;
    public GameObject[] enemyTypes;

    public List<GameObject> enemies;

    [Header("projectiles")]
    public GameObject projectile;
    public Transform projectilePos;

     
    

    // Start is called before the first frame update
    void Start()
    {
        SpawnGroundEnemies();
        SpawnAirEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime; 

        //if(timer > 2)
        //{
        //    timer = 0;
            
        //}
    }

    public void killEnemy(GameObject enemy_)
    {
        if (enemies.Count == 0)
            return;

        Destroy(enemy_);
        enemies.Remove(enemy_);
        GetEnemyCount();
       
    }

    public Transform GetRandomGroundSpawnPoint()
    {
        return spawnPoints[Random.Range(0,2)];
    }
    public Transform GetRandomAirSpawnPoint()
    {
        return spawnPoints[Random.Range(3, 10)];
    }

    private void GetEnemyCount()
    {

    }

    public void SpawnGroundEnemies()
    {
        for (int i = 0; i <= 2; i++)
        {
            int rnd = Random.Range(0, enemyTypes.Length - 1);
            GameObject enemy = Instantiate(enemyTypes[0], spawnPoints[i].position, spawnPoints[i].rotation);
            enemies.Add(enemy);

            
        }
        GetEnemyCount();
    }

    public void SpawnAirEnemies()
    {
        for (int i = 3; i <= 10 ; i++)
        {
            int rnd = Random.Range(0, enemyTypes.Length - 1);
            GameObject enemy = Instantiate(enemyTypes[1], spawnPoints[i].position, spawnPoints[i].rotation);
            enemies.Add(enemy);


        }
        GetEnemyCount();
    }

   


    /// <summary>
    /// event system
    /// </summary>




}
