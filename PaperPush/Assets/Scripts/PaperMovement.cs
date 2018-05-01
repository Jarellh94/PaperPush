using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperMovement : MonoBehaviour {

    public float moveSpeed = 5;
    public float stopPoint = 3;

    bool spawning = true;
    bool moving = false;
    int moveDir = 0;
    bool gameOver = false;

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
        if (spawning)
        {
            //transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            if (transform.position.z <= stopPoint)
                Stop();
        }
		else if(moving && !gameOver)
        {
            //transform.Translate(Vector3.right * moveDir * moveSpeed * Time.deltaTime);
        }
	}

    public void Stop()
    {
        transform.position.Set(transform.position.x, transform.position.y, stopPoint);
        spawning = false;
        moving = false;
    }

    public void MoveLeft()
    {
        anim.SetTrigger("Left");
        moving = true;
        //moveDir = -1;
    }

    public void MoveRight()
    {
        anim.SetTrigger("Right");
        moving = true;
        //moveDir = 1;
    }

    public void GameEnded()
    {
        gameOver = true;
        spawning = false;
        moving = false;
    }
}
