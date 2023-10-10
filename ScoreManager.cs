using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public int highscore;
    public TextMeshProUGUI highscoreText;

    public void IncreaseScore(int amount)
    {
        score += amount;
        updateScoreText();
    }

    void Start()
    {
        updateScoreText();
    }

    void updateScoreText ()
    {
        scoreText.text = "Highscore: " + score;
        highscoreText.text = "Score: " + highscore;
    }

    private void Update()
    {
        if(score > highscore)
        {
            highscore=score;
        }
    }
}