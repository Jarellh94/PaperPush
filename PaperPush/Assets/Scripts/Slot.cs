using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour {

    public bool right = false;

    PaperSpawner spawner;

	// Use this for initialization
	void Start () {
        spawner = FindObjectOfType<PaperSpawner>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Paper"))
        {
            string loc = right ? "Right" : "Left";

            spawner.NewPaper();
            Destroy(other.gameObject);
            Debug.Log(loc + " Got It");
        }
    }
}
