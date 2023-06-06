using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottomLeft;

    public GameObject gameOverPanel, gameStartPanel;

    public static bool gameOver;
    public static int gameScore;
    bool gameStart;


    public GameObject score;
    void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
    }

    private void Start()
    {
        gameOver = false;
        gameOverPanel.SetActive(false);
    }

    

    public void GameOver()
    {
        gameOver = true;
        gameScore = score.GetComponent<Score>().GetScore();
        gameOverPanel.SetActive(true);
        score.SetActive(false);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void GameStart()
    {
        gameStartPanel.SetActive(false);
    }
}
