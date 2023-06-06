using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    int highScore;
    int score;
    Text scoreText;

    public Text panelScore;
    public Text panelHighScore;

    public GameObject newHighScore;

    void Start()
    {
        score = 0;
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
        panelScore.text= score.ToString();

        highScore = PlayerPrefs.GetInt("highscore", highScore);
        panelHighScore.text = highScore.ToString();
    }

    public void Scored()
    {
        score++;
        scoreText.text = score.ToString();
        panelScore.text = score.ToString();

        if (score>highScore)
        {
            highScore = score;
            panelHighScore.text = highScore.ToString();
            newHighScore.SetActive(true);
            PlayerPrefs.SetInt("highscore",highScore);

        }
    }

    public int GetScore()
    {
        return score;
    }
}
