﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherSight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D (Collider2D other)
     {
         if (other.gameObject.tag == "Player")
         {
             Debug.Log ("I found you!");
             LevelControl.instance.youLose();
            //  GameManager.instance.Result("YOU LOSE!");
            //  FindObjectOfType<GameManager>().EndGame();
         }
     }
}
