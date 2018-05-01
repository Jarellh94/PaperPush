using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveGameObjectToggle : MonoBehaviour {

	public void ToggleActive()
    {
        if (gameObject.activeSelf)
            gameObject.SetActive(false);
        else
            gameObject.SetActive(true);
    }
}
