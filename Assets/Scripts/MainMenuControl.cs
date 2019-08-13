﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour{

	public Button level02Button, level03Button, level04Button;
	public Image level1, level2, level3, level4;
	public Image locklevel1, locklevel2, locklevel3, locklevel4;
	int levelPassed;

	// Start is called before the first frame update
	void Start(){
		levelPassed = PlayerPrefs.GetInt("LevelPassed");
		Debug.Log("MAIN levelPassed: " + levelPassed);
		level02Button.interactable = false;
		level03Button.interactable = false;
		level04Button.interactable = false;

		level1.enabled=true;
		level2.enabled=false;
		level3.enabled=false;
		level4.enabled=false;

		locklevel1.enabled=false;
		locklevel2.enabled=true;
		locklevel3.enabled=true;
		locklevel4.enabled=true;

		switch(levelPassed){
			case 2:
				Debug.Log("level2Passed: " + levelPassed);
				level02Button.interactable = true;
				level2.enabled=true;
				locklevel2.enabled=false;
				break;
			case 4:
				Debug.Log("level4Passed: " + levelPassed);
				level02Button.interactable = true;
				level03Button.interactable = true;
				level2.enabled=true;
				level3.enabled=true;
				locklevel2.enabled=false;
				locklevel3.enabled=false;
				break;
			case 6:
				Debug.Log("level6Passed: " + levelPassed);
				level02Button.interactable = true;
				level03Button.interactable = true;
				level04Button.interactable = true;
				level2.enabled=true;
				level3.enabled=true;
				level4.enabled=true;
				locklevel2.enabled=false;
				locklevel3.enabled=false;
				locklevel4.enabled=false;
				break;
			case 8:
				Debug.Log("level8Passed: " + levelPassed);
				level02Button.interactable = true;
				level03Button.interactable = true;
				level04Button.interactable = true;
				level2.enabled=true;
				level3.enabled=true;
				level4.enabled=true;
				locklevel2.enabled=false;
				locklevel3.enabled=false;
				locklevel4.enabled=false;
				break;
		}
	}

	public void levelToLoad (int level){
		SceneManager.LoadScene(level);
	}

	public void resetPlayerPrefs(){
		level02Button.interactable = false;
		level03Button.interactable = false;
		level04Button.interactable = false;

		level1.enabled=true;
		level2.enabled=false;
		level3.enabled=false;
		level4.enabled=false;

		locklevel1.enabled=false;
		locklevel2.enabled=true;
		locklevel3.enabled=true;
		locklevel4.enabled=true;
		PlayerPrefs.DeleteAll();
	}

	public void highScores(){
		SceneManager.LoadScene(11);
	}
}
