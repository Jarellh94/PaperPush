using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperInfo : MonoBehaviour {

    public GameObject leftStamp;
    public GameObject rightStamp;
    Text verseText;
    public SmartTextMesh myText;
    public SmartTextMesh verseSourceText;

    SlotSide target;

    Scripture myScripture;

    void Start()
    {
        rightStamp.SetActive(false);
        leftStamp.SetActive(false);
        /*
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
        }*/
    }
    
    public void SetScripture(Scripture mine)
    {
        myScripture = mine;

        myText.UnwrappedText = myScripture.text;
        myText.NeedsLayout = true;

        verseSourceText.UnwrappedText = myScripture.verse;
        verseSourceText.NeedsLayout = true;

        if (myScripture.isAccurate)
            target = SlotSide.RIGHT;
        else
            target = SlotSide.LEFT;
    }

    public SlotSide GetTarget()
    {
        return target;
    }
}
