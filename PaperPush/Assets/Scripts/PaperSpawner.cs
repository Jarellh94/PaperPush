using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperSpawner : MonoBehaviour {

    public GameObject paperPrefab;
    public Transform paperSpawnPoint;

    public List<Scripture> scriptures;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NewPaper()
    {
        GameObject newPaper = Instantiate(paperPrefab, paperSpawnPoint.position, Quaternion.identity) as GameObject;

        int ran = Random.Range(0, scriptures.Count);

        newPaper.GetComponent<PaperInfo>().SetScripture(scriptures[ran]);
    }
}

[System.Serializable]
public class Scripture
{
    public string verse;
    public string text;

    public bool isAccurate;
}
