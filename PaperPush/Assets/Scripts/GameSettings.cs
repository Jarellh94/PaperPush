using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour {

    public int difficulty = 2;
    public bool timedGame = false;

    private float defaultVolume;
    private static GameSettings gameSettings;


    // Use this for initialization
    void Start () {
        if (gameSettings == null)
            gameSettings = this;
        else
            Destroy(this.gameObject);

        Object.DontDestroyOnLoad(gameObject);

        defaultVolume = AudioListener.volume;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetDifficulty(int diff)
    {
        difficulty = diff;
    }

    public int GetDifficulty()
    {
        return difficulty;
    }

    public void SetTimedGame(bool value)
    {
        timedGame = value;
    }

    public bool GetGameMode()
    {
        return timedGame;
    }

    public void ToggleVolume()
    {
        if (AudioListener.volume > 0)
            AudioListener.volume = 0;
        else if (AudioListener.volume == 0)
            AudioListener.volume = defaultVolume;
    }

    public void SetHighScore(int value)
    {
        switch(difficulty)
        {
            case 1:
                if(!timedGame)
                    PlayerPrefs.SetInt("SurvEasy", value);
                else
                    PlayerPrefs.SetInt("TimeEasy", value);
                break;
            case 2:
                if (!timedGame)
                    PlayerPrefs.SetInt("SurvMed", value);
                else
                    PlayerPrefs.SetInt("TimeMed", value);
                break;
            case 3:
                if (!timedGame)
                    PlayerPrefs.SetInt("SurvHard", value);
                else
                    PlayerPrefs.SetInt("TimeHard", value);
                break;
            default:
                if (!timedGame)
                    PlayerPrefs.SetInt("SurvEasy", value);
                else
                    PlayerPrefs.SetInt("TimeEasy", value);
                break;
        }
    }

    public void ResetHighScores()
    {
        PlayerPrefs.SetInt("SurvEasy", 0);
        PlayerPrefs.SetInt("SurvMed", 0);
        PlayerPrefs.SetInt("SurvHard", 0);

        PlayerPrefs.SetInt("TimeEasy", 0);
        PlayerPrefs.SetInt("TimeMed", 0);
        PlayerPrefs.SetInt("TimeHard", 0);
    }

    public int GetHighScore()
    {
        switch (difficulty)
        {
            case 1:
                if (timedGame)
                    return PlayerPrefs.GetInt("TimeEasy");
                else
                    return PlayerPrefs.GetInt("SurvEasy");
            case 2:
                if (timedGame)
                    return PlayerPrefs.GetInt("TimeMed");
                else
                    return PlayerPrefs.GetInt("SurvMed");
            case 3:
                if (timedGame)
                    return PlayerPrefs.GetInt("TimeHard");
                else
                    return PlayerPrefs.GetInt("SurvHard");
            default:
                if (timedGame)
                    return PlayerPrefs.GetInt("TimeEasy");
                else
                    return PlayerPrefs.GetInt("SurvEasy");
        }
    }

    public int GetHighScore(bool gameMode)
    {
        switch (difficulty)
        {
            case 1:
                if (gameMode)
                    return PlayerPrefs.GetInt("TimeEasy");
                else
                    return PlayerPrefs.GetInt("SurvEasy");
            case 2:
                if (gameMode)
                    return PlayerPrefs.GetInt("TimeMed");
                else
                    return PlayerPrefs.GetInt("SurvMed");
            case 3:
                if (gameMode)
                    return PlayerPrefs.GetInt("TimeHard");
                else
                    return PlayerPrefs.GetInt("SurvHard");
            default:
                if (gameMode)
                    return PlayerPrefs.GetInt("TimeEasy");
                else
                    return PlayerPrefs.GetInt("SurvEasy");
        }
    }
}
