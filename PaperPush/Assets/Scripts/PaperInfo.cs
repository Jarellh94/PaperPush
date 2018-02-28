using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperInfo : MonoBehaviour {

    public GameObject leftStamp;
    public GameObject rightStamp;

    SlotSide target;

    void Start()
    {
        int ran = Random.Range(1, 3);

        target = ran == 1 ? SlotSide.LEFT : SlotSide.RIGHT;

        if(target == SlotSide.RIGHT)
        {
            rightStamp.SetActive(true);
            leftStamp.SetActive(false);
        }
        else
        {
            rightStamp.SetActive(false);
            leftStamp.SetActive(true);
        }
    }
    

    public SlotSide GetTarget()
    {
        return target;
    }
}
