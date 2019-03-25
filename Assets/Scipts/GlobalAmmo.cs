using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GlobalAmmo : MonoBehaviour
{
    public static int CurrentAmmo;
    int InternalAmmo;
    GameObject AmmoDisplay;

    void Update()
    {
        InternalAmmo = CurrentAmmo;
        AmmoDisplay.GetComponent< Text > ().text = "" + InternalAmmo;
    }

}
