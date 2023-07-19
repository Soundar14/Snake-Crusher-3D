using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : Singleton<GameManager>
{
    public TextMeshProUGUI ScoreText;
    public int ScoreCount;
    public int AllEnemyCount;

    bool isNextItr;

    [SerializeField] GameObject gameOverPanel;
    void Start()
    {
        
    }

    public void UpdateScore()
    {
        ScoreCount++;
        AllEnemyCount--;
        ScoreText.text = "SCORE : " + ScoreCount.ToString();
    }

    public void Restart()
    {
        Time.timeScale = 1.0f;
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene(0);
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if(!isNextItr && AllEnemyCount == 0)
        {
            GameOver();
            isNextItr = true;
        }
    }
}
