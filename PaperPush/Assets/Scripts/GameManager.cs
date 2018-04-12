using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    PaperSpawner spawner;
    ScoreManager scoreMan;

    // Use this for initialization
    void Start () {
        spawner = GetComponent<PaperSpawner>();
        scoreMan = GetComponent<ScoreManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CorrectSort()
    {
        scoreMan.AddScore(1);
        spawner.NewPaper();
    }

    public void WrongSort()
    {
        spawner.EndGame();
    }
}
