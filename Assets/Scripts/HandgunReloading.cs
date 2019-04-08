using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandgunReloading : MonoBehaviour {
    // Declaring variables
    AudioSource ReloadSound;
    GameObject CrossObject;
    GameObject MechanicsObject;
    int ClipCount;
    int ReserveCount;
    int ReloadAvailable;





    void ActionReload()
    {
        this.GetComponent < GunFire > ().enabled = false;
        CrossObject.SetActive(false);
        MechanicsObject.SetActive(false);
        ReloadSound.Play();
        GetComponent< Animation > ().Play("HandgunReload");
    }
}
