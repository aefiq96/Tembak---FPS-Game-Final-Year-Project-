using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunDamage : MonoBehaviour
{   //declaring variables
    int DamageAmount = 5;
    float TargetDistance;
    float AllowedRange = 15;

    public RaycastHit hit;
    public GameObject TheBullet;
    public GameObject TheBlood;
    public GameObject TheBloodGreen;

    void Update()
    {
        if (GlobalAmmo.LoadedAmmo >= 1)
        {   //if statements to enable the gun to shoot, sound & damage count
            if (Input.GetButtonDown("Fire1"))
            {
                RaycastHit Shot;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
                {
                    TargetDistance = Shot.distance;
                    if (TargetDistance < AllowedRange)
                    {
                        //Shot.transform.SendMessage("DeductPoints", DamageAmount);
                        Shot.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
                        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
                        {
                            if (hit.transform.tag == "Zombie")
                            {
                                Instantiate(TheBlood, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                            }
                            if (hit.transform.tag == "Spider")
                            {
                                Instantiate(TheBloodGreen, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                            }
                            if(hit.transform.tag == "Untagged")
                            {
                                Instantiate(TheBullet, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                            }
                        }
                    }
                }
            }
        }
    }
}