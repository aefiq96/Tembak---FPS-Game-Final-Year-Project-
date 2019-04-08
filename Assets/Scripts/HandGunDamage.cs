using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunDamage : MonoBehaviour
{   //declaring variables
    int DamageAmount = 5;
    float TargetDistance;
    float AllowedRange = 15;

    void Update()
    {
        if (GlobalAmmo.LoadedAmmo >= 1)
        {
            //if statements to enable the gun to shoot, sound & damage amount
            if (Input.GetButtonDown("Fire1"))
            {

                RaycastHit Shot;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
                {
                    TargetDistance = Shot.distance;
                    if (TargetDistance < AllowedRange)
                    {
                        Shot.transform.SendMessage("DeductPoints", DamageAmount);
                    }
                }
            }
        }
    }
}