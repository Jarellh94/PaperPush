using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySetting : MonoBehaviour {

    public int difficulty = 2;

	// Use this for initialization
	void Start () {

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
}
