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
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
