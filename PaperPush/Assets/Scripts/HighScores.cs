using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour {

    public bool isTimedScore = false;
    bool settingsMode = false;

    public Text scoreText;

    GameSettings settings;

	// Use this for initialization
	void Start () {
        settings = FindObjectOfType<GameSettings>();

        settingsMode = settings.GetGameMode();

        GetMyHighScoreValue();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GetHighScoreValue()
    {
        settings = FindObjectOfType<GameSettings>();
        int score = settings.GetHighScore();

        scoreText.text = "High Score: " + score.ToString();
    }

    public void GetMyHighScoreValue()
    {
        settings = FindObjectOfType<GameSettings>();
        int score = settings.GetHighScore(isTimedScore);

        scoreText.text = "High Score: " + score.ToString();
    }
    /*
    public void GetHighScoreValue(bool isTimedScore)
    {
        int score = settings.GetHighScore(isTimedScore);

        scoreText.text = "High Score: " + score.ToString();
    }*/

    public void SetHighScore(int score)
    {
        Debug.Log("Setting High Score to " + score);
        settings = FindObjectOfType<GameSettings>();

        settings.SetHighScore(score);
        GetHighScoreValue();
    }
}
