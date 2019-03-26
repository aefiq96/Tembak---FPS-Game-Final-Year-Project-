using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public AudioSource AmmoSound;

    void OnTriggerEnter(Collider col)
    {
        AmmoSound.Play();
        GlobalAmmo.CurrentAmmo += 10;
        this.gameObject.SetActive(false);
    }
}
