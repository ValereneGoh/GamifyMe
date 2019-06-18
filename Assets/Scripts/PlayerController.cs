﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
	private Rigidbody2D player;

	public float moveSpeed;
	public float turnSpeed;

    // Start is called before the first frame update
    void Start(){
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){

    }

    void FixedUpdate(){
    	float moveHorizontal = Input.GetAxis ("Horizontal");
    	float moveVertical = Input.GetAxis ("Vertical");
    	Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        //move body
    	transform.Translate (movement * moveSpeed * Time.deltaTime, Space.World);
        //rotate body
    	if (movement != Vector2.zero) {
         transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward, movement), Time.fixedDeltaTime * turnSpeed);
    	}
    }

}
