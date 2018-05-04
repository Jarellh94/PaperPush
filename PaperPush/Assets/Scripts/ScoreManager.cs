﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text endScoreText;
    public Text labelText;
    public HighScores highScore;

    int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

    public void AddScore(int amt)
    {
        score += amt;
        UpdateScore();
    }

    public void AddTimedScore(int amt)
    {
        score += amt;
    }

    public void UpdateScore()
    {
        scoreText.text = score.ToString();
        endScoreText.text = "Your Score: " + score.ToString();
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScore();
    }

    public void EndSurvGame()
    {
        UpdateScore();
        highScore.SetHighScore(score);
    }

    public void EndTimedGame()
    {
        UpdateScore();
        labelText.text = "Incorrect Verses: ";
        highScore.SetHighScore(score);
    }
}
