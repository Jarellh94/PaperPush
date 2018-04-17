using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour {

    public int difficulty = 2;
    public bool timedGame = false;

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
}
