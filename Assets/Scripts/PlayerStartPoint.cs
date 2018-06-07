using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour {

	private PlayerController player;
	private CameraController theCamera;

	void Start () {
		player = FindObjectOfType<PlayerController>();
		player.transform.position = transform.position;

		theCamera = FindObjectOfType<CameraController>();
		theCamera.transform.position = new Vector3(transform.position.x, transform.position.y, camera.transform.position.z);
	}
	
	void Update () {
		
	}
}
