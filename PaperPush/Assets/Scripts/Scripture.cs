using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Verse", menuName = "Scripture", order = 1)]
public class Scripture : ScriptableObject{

    public string verse;
    [TextArea]
    public string text;

    public bool isAccurate;
}
