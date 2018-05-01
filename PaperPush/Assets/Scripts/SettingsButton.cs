using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton : MonoBehaviour {

    GameSettings settings;

	// Use this for initialization
	void Start () {
        settings = FindObjectOfType<GameSettings>();
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

    public void ToggleVolume()
    {
        settings.ToggleVolume();
    }
}
