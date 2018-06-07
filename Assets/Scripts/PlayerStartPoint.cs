using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour {

	private PlayerController player;
	private CameraController cam;

	public Vector2 startDirection;

	void Start () {
		player = FindObjectOfType<PlayerController>();
		player.transform.position = transform.position;
		//player.lastMove = startDirection;

		cam = FindObjectOfType<CameraController>();
		cam.transform.position = new Vector3(transform.position.x, transform.position.y, GetComponent<Camera>().transform.position.z);
	}
}
