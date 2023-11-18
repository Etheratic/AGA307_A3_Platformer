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
    }



}
