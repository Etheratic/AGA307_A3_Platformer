using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public enum GameState
{
    Title, Playing, GameOver, Win, Paused
}
public class GameManager : Singleton<GameManager>
{
    public GameState gameState;
    public int score = 0;
    private int scoreMultiplier;
    public int coinCounter;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddCoin()
    {
        coinCounter += 1;
        _UI.UpdateScore(coinCounter);
    }

    //public void AddScore(int _points)
    //{
    //    score += _points + coinCounter;

    //}

    private void OnEnemyHit(GameObject _enemy)
    {
        int _score = _enemy.GetComponent<Enemy>().myScore;

        //AddScore(_score);
    }
    private void OnEnable()
    {
        Enemy.OnEnemyHit += OnEnemyHit;
        Enemy.OnEnemyDie += OnEnemyHit;
    }

    private void OnDisable ()
    {
        Enemy.OnEnemyHit -= OnEnemyHit;
        Enemy.OnEnemyDie -= OnEnemyHit;
    }



}
