using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        GlobalAmmo.CurrentAmmo += 10;
        this.gameObject.SetActive(false);
    }
}
