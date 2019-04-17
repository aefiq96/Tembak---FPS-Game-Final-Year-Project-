﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    //Declaring variables
    public GameObject ThePlayer;
    public GameObject TheEnemy;
    public float EnemySpeed;
    public int MoveTrigger;

    // if function for the enemy to constantly towards the player
    void Update()
    {
        if (MoveTrigger == 1)
        {
            EnemySpeed = 0.02f;
            transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
        }
    }
}
