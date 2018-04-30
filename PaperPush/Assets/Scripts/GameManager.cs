using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    PaperSpawner spawner;
    ScoreManager scoreMan;

    public bool timedGame = false;

    public int timeLimit = 30;
    float timer = 0;

    public Text timerText;

    public GameObject leftSlot, rightSlot;

    // Use this for initialization
    void Start () {
        spawner = GetComponent<PaperSpawner>();
        scoreMan = GetComponent<ScoreManager>();

        if (FindObjectOfType<GameSettings>() != null)
        {
            spawner.difficulty = FindObjectOfType<GameSettings>().GetDifficulty();
            timedGame = FindObjectOfType<GameSettings>().GetGameMode();
        }
    }
	
	// Update is called once per frame
	void Update () {

        //Timed games need to be different, because the game doesn't end when you make a mistake, and it should keep track of all cards sorted.
        if(timedGame)
        {
            timer += Time.deltaTime;
            timerText.text = (timeLimit - (int)timer).ToString();

            if (timer > timeLimit)
            {
                spawner.EndTimedGame();
                leftSlot.SetActive(false);
                rightSlot.SetActive(false);
                scoreMan.EndTimedGame();
            }
        }
	}

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        /*
        spawner.StartGame();

        scoreMan.ResetScore();

        leftSlot.SetActive(true);
        rightSlot.SetActive(true);*/
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
