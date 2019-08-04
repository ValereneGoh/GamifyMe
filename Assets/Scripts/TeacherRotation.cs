﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherRotation : MonoBehaviour{
	public float AngleRange;
	public float rotationSpeed = 0.3f;
	public float initialAngle;

	void Start(){
		initialAngle = transform.rotation.eulerAngles.z;
	}
    // Update is called once per frame
    void Update(){
		float angle = Mathf.Sin(Time.time*rotationSpeed) * (AngleRange/2) + initialAngle;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}
}