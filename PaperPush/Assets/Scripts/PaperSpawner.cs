using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperSpawner : MonoBehaviour {

    public GameObject paperPrefab;
    public Transform paperSpawnPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NewPaper()
    {
        Instantiate(paperPrefab, paperSpawnPoint.position, Quaternion.identity);
    }
}
