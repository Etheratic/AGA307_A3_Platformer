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

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void killEnemy(GameObject enemy_)
    {
        if (enemies.Count == 0)
            return;

        Destroy(enemy_);
        enemies.Remove(enemy_);
        GetEnemyCount();
       
    }

    public Transform GetRandomSpawnPoint()
    {
        return spawnPoints[Random.Range(0, spawnPoints.Length)];
    }

    private void GetEnemyCount()
    {

    }

    public void SpawnEnemies()
    {
        for (int i = 0; i <= spawnPoints.Length - 1; i++)
        {
            int rnd = Random.Range(0, enemyTypes.Length - 1);
            GameObject enemy = Instantiate(enemyTypes[0], spawnPoints[i].position, spawnPoints[i].rotation);
            enemies.Add(enemy);

            
        }
        GetEnemyCount();
    }
    /// <summary>
    /// event system
    /// </summary>




}
