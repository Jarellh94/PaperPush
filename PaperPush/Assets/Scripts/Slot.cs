using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SlotSide{RIGHT, LEFT};

public class Slot : MonoBehaviour {
    
    public SlotSide mySide;

    PaperSpawner spawner;
    ScoreManager scoreMan;

	// Use this for initialization
	void Start () {
        spawner = FindObjectOfType<PaperSpawner>();
        scoreMan = FindObjectOfType<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Paper"))
        {
            if(other.gameObject.GetComponent<PaperInfo>().GetTarget() == mySide)
            {
                scoreMan.AddScore(1);
                spawner.NewPaper();
            }
            else
            {
                Debug.Log("Mistake!");
            }
            

            Destroy(other.gameObject);
        }
    }
}
