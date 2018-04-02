using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public static bool isPaused = false;
    public GameObject pauseMenu;
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PauseGame()
    {
        isPaused = true;

        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        isPaused = false;

        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    public void QuitGame()
    {
        isPaused = false;

        Time.timeScale = 1f;
    }
}
