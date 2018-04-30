using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperSpawner : MonoBehaviour {

    public GameObject paperPrefab;
    public Transform paperSpawnPoint;

    public GameObject endGamePanel;
    public GameObject gamePanel;
    
    public List<Scripture> easyScriptures;
    public List<Scripture> mediumScriptures;
    public List<Scripture> hardScriptures;

    private List<Scripture> currentScriptures = new List<Scripture>();

    //public List<GameObject> endPapers = new List<GameObject>();
    public GameObject IncorrectVersesList;

    public int difficulty = 1;

    private int curIter = 0;

    ScoreManager scoreMan;
    GameObject newPaper = null;

    // Use this for initialization
    void Start () {
        scoreMan = gameObject.GetComponent<ScoreManager>();
        StartGame();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NewPaper()
    {
        /*
        GameObject newPaper = Instantiate(paperPrefab, paperSpawnPoint.position, Quaternion.identity) as GameObject;

        int ran = Random.Range(0, currentScriptures.Count);

        newPaper.GetComponent<PaperInfo>().SetScripture(currentScriptures[ran]);*/

        if (curIter < currentScriptures.Count)
        {
            newPaper = Instantiate(paperPrefab, paperSpawnPoint.position, Quaternion.identity) as GameObject;

            newPaper.GetComponent<PaperInfo>().SetScripture(currentScriptures[curIter]);

            curIter++;
        }
        else
        {
            ShuffleCards();
            curIter = 0;
            NewPaper();
        }
    }

    public void StartGame()
    {
        ShuffleCards();
        if (newPaper != null)
            Destroy(newPaper);
        NewPaper();

        //IncorrectVersesList.GetComponent<IncorrectVerses>().StartGame();
    }

    public void EndGame()
    {
        newPaper = Instantiate(paperPrefab, paperSpawnPoint.position, Quaternion.identity) as GameObject;
        newPaper.GetComponent<PaperInfo>().SetScripture(currentScriptures[--curIter]);

        newPaper.GetComponent<PaperMovement>().GameEnded();
        newPaper.GetComponent<PaperInfo>().GameEnded();

        endGamePanel.SetActive(true);
        gamePanel.SetActive(false);
    }

    public void EndTimedGame()
    {
        if (newPaper != null)
            Destroy(newPaper);

        endGamePanel.SetActive(true);
        gamePanel.SetActive(false);
        IncorrectVersesList.SetActive(true);
    }

    public void WrongCard()
    {
        GameObject endPaper = Instantiate(paperPrefab, paperSpawnPoint.position, Quaternion.identity) as GameObject;
        endPaper.GetComponent<PaperInfo>().SetScripture(currentScriptures[curIter-1]);

        endPaper.GetComponent<PaperMovement>().GameEnded();
        endPaper.GetComponent<PaperInfo>().GameEnded();

        //endPaper.SetActive(false);

        //endPapers.Add(endPaper);
        IncorrectVersesList.GetComponent<IncorrectVerses>().AddVerseObject(endPaper);
        NewPaper();

    }

    private void ShuffleCards()
    {
        switch(difficulty)
        {
            case 1:
                currentScriptures.AddRange(easyScriptures);
                break;
            case 2:
                currentScriptures.AddRange(mediumScriptures);
                goto case 1;
            case 3:
                currentScriptures.AddRange(hardScriptures);
                goto case 2;
        }

        for(int i = 0; i < currentScriptures.Count-1; i++)
        {
            int j = Random.Range(i, currentScriptures.Count);

            Scripture temp = currentScriptures[i];

            currentScriptures[i] = currentScriptures[j];

            currentScriptures[j] = temp;
        }
    }
}
/*
[System.Serializable]
public class Scripture
{
    public string verse;
    public string text;

    public bool isAccurate;
}*/
