using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickupSMG : MonoBehaviour
{   //declaring variable
    public AudioSource AmmoSound;

    void OnTriggerEnter(Collider col)
    {   //creates ammo sound when being picked up, also adds ammo
        AmmoSound.Play();

        if (GlobalAmmo.LoadedAmmo == 0)
        {
            GlobalAmmo.LoadedAmmo += 30;
            this.gameObject.SetActive(false);
        }
        else
        {
            GlobalAmmo.CurrentAmmo += 30;
            this.gameObject.SetActive(false);
        }

    }
}

