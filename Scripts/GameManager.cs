using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    bool gameOver = false;
    int score = 0;
    

    public Text HighscoreText;
    public Text ScoreText;
    public GameObject gameOverPanel;

    private void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        HighscoreText.text = PlayerPrefs.GetInt("highscore", 0).ToString();
    }


    public void GameOver()
    {
        gameOver = true;

        GameObject.Find("ObstacleSpawner").GetComponent<ObstacleSpawner>().StopSpawning();

        gameOverPanel.SetActive(true);
    }
    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            ScoreText.text = score.ToString();
            
        }

        if (score > PlayerPrefs.GetInt("highscore", 0))
        {
            PlayerPrefs.SetInt("highscore", score);
            HighscoreText.text = score.ToString();

        }
    }

    public void HighScore() 
    { 
        

    }
    public void Restart()
    {
        
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {
         SceneManager.LoadScene("MainMenu");
    }
}
