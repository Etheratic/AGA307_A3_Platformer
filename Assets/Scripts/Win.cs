using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : GameBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        _UI.gameOverPanel.SetActive(true);
    }

    
}
