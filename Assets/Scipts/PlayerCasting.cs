using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This Script enables the makeshift button by the door
public class PlayerCasting : MonoBehaviour

{   // declaring variables
    float DistanceFromTarget;
    float ToTarget; //how far it is to the target

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            ToTarget = hit.distance;
            DistanceFromTarget = ToTarget;
        }
    }
}
