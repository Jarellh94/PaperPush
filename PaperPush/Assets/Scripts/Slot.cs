using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SlotSide{RIGHT, LEFT};

public class Slot : MonoBehaviour {
    
    public SlotSide mySide;

    public Transform particleSpawnPoint;

    public GameObject correctParticles;
    public GameObject wrongParticles;

    GameObject particleHolder;

    PaperSpawner spawner;
    ScoreManager scoreMan;

    GameManager gameMan;

	// Use this for initialization
	void Start () {
        spawner = FindObjectOfType<PaperSpawner>();
        scoreMan = FindObjectOfType<ScoreManager>();
        gameMan = FindObjectOfType<GameManager>();
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
                gameMan.CorrectSort();

                if (mySide == SlotSide.LEFT)
                    particleHolder = Instantiate(correctParticles, particleSpawnPoint.position, Quaternion.Euler(0, 90, 0));
                else
                    particleHolder = Instantiate(correctParticles, particleSpawnPoint.position, Quaternion.Euler(0, -90, 0));


                Destroy(particleHolder, 1f);
            }
            else
            {
                gameMan.WrongSort();
                
                Debug.Log("Mistake!");
                if (mySide == SlotSide.LEFT)
                    particleHolder = Instantiate(wrongParticles, particleSpawnPoint.position, Quaternion.Euler(0, 90, 0));
                else
                    particleHolder = Instantiate(wrongParticles, particleSpawnPoint.position, Quaternion.Euler(0, -90, 0));
                
                Destroy(particleHolder, 1f);
                
            }
            

            Destroy(other.gameObject);
        }
    }
}
