using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncorrectVerses : MonoBehaviour {

    public GameObject myHandle;
    public float moveSpeed = .1f;

    int numObjects = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddVerseObject(GameObject verseObject)
    {
        verseObject.transform.SetParent(transform);
        verseObject.transform.position = new Vector3((numObjects * 5.5f), 0, 3);


        myHandle.transform.localScale += new Vector3(6f, 0);
        myHandle.transform.Translate(new Vector3(3f, 0));

        numObjects++;
    }

    public void MoveList(float dist)
    {
        transform.Translate(new Vector3(dist * Time.deltaTime * moveSpeed,0));
    }

    public void StartGame()
    {
        while(transform.childCount > 1)
        {
            Destroy(transform.GetChild(1));
        }

        myHandle.transform.localScale = new Vector3(6, 0.4f, 7.5f);
        gameObject.SetActive(false);
    }
}
