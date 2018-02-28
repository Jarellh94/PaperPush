using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperMovement : MonoBehaviour {

    public float moveSpeed = 5;

    bool spawning = true;
    bool moving = false;
    int moveDir = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (spawning)
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
		else if(moving)
        {
            transform.Translate(Vector3.right * moveDir * moveSpeed * Time.deltaTime);
        }
	}

    public void Stop()
    {
        spawning = false;
        moving = false;
    }

    public void MoveLeft()
    {
        moving = true;
        moveDir = -1;
    }

    public void MoveRight()
    {
        moving = true;
        moveDir = 1;
    }
}
