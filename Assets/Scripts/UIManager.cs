using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : Singleton<UIManager>
{
    public TMP_Text coinText;
    public TMP_Text TimeText;
    public GameObject gameOverPanel;

    private void Start()
    {
        UpdateScore(0);
        UpdateTime(0);
        gameOverPanel.SetActive(false);
        


    }

    public void UpdateScore(int _coins)
    {
        coinText.text = "Coins: " + _coins;
    }

    public void UpdateTime(float _time)
    {
        TimeText.text = _time.ToString("F2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
