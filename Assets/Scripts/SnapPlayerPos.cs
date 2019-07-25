﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapPlayerPos : MonoBehaviour{

	public float x;
	public float y;
	private GameObject Player;
	private GameObject ExamBar;
	private PlayerController PlayerController;
	private CheatBar CheatBar_English;
	private CheatBar CheatBar_Math;
	private CheatBar CheatBar_Science;
	public static bool inSnapPos=true;

    // Start is called before the first frame update
    void Start(){
    	Player = GameObject.Find("Player");
    	PlayerController=Player.GetComponent<PlayerController>();
			ExamBar = GameObject.Find("cheatbar (english)");
			CheatBar_English = ExamBar.GetComponent<CheatBar>();
			ExamBar = GameObject.Find("cheatbar (math)");
			CheatBar_Math = ExamBar.GetComponent<CheatBar>();
			ExamBar = GameObject.Find("cheatbar (science)");
			CheatBar_Science = ExamBar.GetComponent<CheatBar>();
    }

    // Update is called once per frame
    void Update(){

    }

    void OnTriggerEnter2D(Collider2D other){
			if(other.tag=="Player"){
				StartCoroutine(Freeze(1f));
				other.transform.eulerAngles = new Vector3(0,0,0);
				other.transform.position = new Vector3(x, y, 0);

				// Locks the cheatbar
				CheatBar_English.cheatBarLock();
				CheatBar_Science.cheatBarLock();
				CheatBar_Math.cheatBarLock();

				// Immune to TeacherSight
				inSnapPos=true;

				// If above benchmark wins
				if(CheatBar_English.size >= 0.3f && CheatBar_Math.size >= 0.3f && CheatBar_Science.size>= 0.3f){
					LevelControl.instance.youWin();
				}
			}
		}
	void OnTriggerExit2D(Collider2D other){
		inSnapPos=false;
	}
	IEnumerator Freeze(float time){
		PlayerController.movable = false;
		yield return new WaitForSeconds(time);
		PlayerController.movable = true;
	}
}
