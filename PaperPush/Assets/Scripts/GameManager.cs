using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    PaperSpawner spawner;
    ScoreManager scoreMan;

    public bool timedGame = false;

    public int timeLimit = 30;
    float timer = 0;

    public Text timerText;

    // Use this for initialization
    void Start () {
        spawner = GetComponent<PaperSpawner>();
        scoreMan = GetComponent<ScoreManager>();
    }
	
	// Update is called once per frame
	void Update () {

        if(timedGame)
        {
            timer += Time.deltaTime;
            timerText.text = (timeLimit - (int)timer).ToString();

            if (timer > timeLimit)
            {
                spawner.EndTimedGame();
            }
        }
	}

    public void CorrectSort()
    {
        if (timedGame)
            scoreMan.AddTimedScore(1);
        else
            scoreMan.AddScore(1);

        spawner.NewPaper();
    }

    public void WrongSort()
    {
        if(timedGame)
        {
            spawner.WrongCard();
        }

        else
            spawner.EndGame();
    }
}
