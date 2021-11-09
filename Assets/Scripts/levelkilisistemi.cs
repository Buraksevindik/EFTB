using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelkilisistemi : MonoBehaviour
{
    public Button l1b, l2b, l3b, l4b, l5b, l6b, l7b, l8b, l9b, l10b;
    public static bool seviye1, seviye2, seviye3, seviye4, seviye5, seviye6, seviye7, seviye8, seviye9,seviye10;
    void Start()
    {
        seviye1 = true;
    }
    void Update()
    {
        if (seviye2 == true)
        {
            l2b.interactable = true;
        }
        if (seviye3==true)
        {
            l3b.interactable = true;
        }
        if (seviye4 == true)
        {
            l4b.interactable = true;
        }
        if (seviye5 == true)
        {
            l5b.interactable = true;
        }
        if (seviye6 == true)
        {
            l6b.interactable = true;
        }
        if (seviye7 == true)
        {
            l7b.interactable = true;
        }
        if (seviye8 == true)
        {
            l8b.interactable = true;
        }
        if (seviye9 == true)
        {
            l9b.interactable = true;
        }
        if (seviye10 == true)
        {
            l10b.interactable = true;
        }
    }
}
