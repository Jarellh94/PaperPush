using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour {

    public int difficulty = 2;
    public bool timedGame = false;
    public float volume = 100f;

    private static GameSettings gameSettings;

    // Use this for initialization
    void Start () {
        if (gameSettings == null)
            gameSettings = this;
        else
            Destroy(this.gameObject);

        Object.DontDestroyOnLoad(gameObject);
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
        if (volume > 0)
            volume = 0;
        if (volume == 0)
            volume = 100;
    }
}
