using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour {

    public float thresh = 1;

    GameObject paperTarget;
    Vector3 startPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(raycast, out hit, 100))
            {
                if (hit.transform.CompareTag("Paper"))
                {
                    paperTarget = hit.transform.gameObject;
                    startPosition = Input.mousePosition;
                }
            }
        }

        if(Input.GetMouseButtonUp(0) && paperTarget != null)
        {
            float xDistance = Input.mousePosition.x - startPosition.x;

            if(xDistance >= thresh)
            {
                paperTarget.GetComponent<PaperMovement>().MoveRight();
            }
            else if(xDistance <= -thresh)
            {
                paperTarget.GetComponent<PaperMovement>().MoveLeft();
            }

            paperTarget = null;
            startPosition = Vector3.zero;
        }

	}
}
