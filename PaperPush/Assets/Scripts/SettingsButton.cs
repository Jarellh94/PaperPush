using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton : MonoBehaviour {

    GameSettings settings;

	// Use this for initialization
	void Start () {
        settings = FindObjectOfType<GameSettings>();

        if (settings == null)
            Debug.Log("Not Found");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetGameMode(bool value)
    {
        settings.SetTimedGame(value);
    }

    public void SetDifficulty(int value)
    {
        settings.SetDifficulty(value);
    }

    public void ResetScores()
    {
        settings.ResetHighScores();
    }

    public void SetHighScore(int value)
    {
        settings.SetHighScore(value);
    }
}
