using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleOff : MonoBehaviour {

    Toggle myToggle;

	// Use this for initialization
	void Start () {
        myToggle = GetComponent<Toggle>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Off()
    {
        myToggle.isOn = false;
    }
}
