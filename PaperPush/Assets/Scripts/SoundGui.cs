using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGui : MonoBehaviour
{

    public GameObject soundOn;
    public GameObject soundOff;

    GameSettings settings;

    // Use this for initialization
    void Start()
    {
        settings = FindObjectOfType<GameSettings>();

        GetSoundValue();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleSound()
    {
        settings.ToggleVolume();
        GetSoundValue();
    }

    public void GetSoundValue()
    {
        if (AudioListener.volume == 0)
        {
            soundOff.SetActive(true);
            soundOn.SetActive(false);
        }
        else
        {
            soundOff.SetActive(false);
            soundOn.SetActive(true);
        }
    }
}
