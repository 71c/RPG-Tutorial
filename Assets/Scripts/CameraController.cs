﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject target;
	private Vector3 targetPosition;
	public float speed;

	private static bool cameraExists;

	void Start () {
		if (!cameraExists) {
			cameraExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
	}
	
	void Update () {
		targetPosition = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
		transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
	}
}
