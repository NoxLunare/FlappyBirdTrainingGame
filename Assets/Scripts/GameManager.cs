using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject loseUI;
    public PipeSpawner pipeSpawner;
    public PlayerController playerController;
    public int points = 0;
    public TextMeshProUGUI scoreText, bestScoreText;
    public int bestScore;
    public string score;

    private void Start() 
    {
        bestScore = PlayerPrefs.GetInt(score);
    }

    public void StartGame()
    {
        pipeSpawner.enabled = true;
        playerController.enabled = true;
        playerController.rb.simulated = true;
    }

    private void ShowLoseUI()
    {
        loseUI.SetActive(true);
    }

    public void RepeatGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    public void OnGameOver()
    {
        ShowLoseUI();
        Time.timeScale = 0;
        if(points>bestScore)
        {
            bestScore=points;
            PlayerPrefs.SetInt(score,points);
            PlayerPrefs.Save();
        }
        bestScoreText.text = bestScore.ToString();
    }

    public void UpdateScore()
    {
        points++;
        scoreText.text = points.ToString();
    }
}
