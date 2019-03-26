using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{   //declaring variable
    int EnemyHealth = 10;

    void DeductPoints(int DamageAmount)
    {   //enemy health taken damage
        EnemyHealth -= DamageAmount;
    }

    void Update()
    {   //if statement for terminating gameObject's health when less than zero 
        if (EnemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
