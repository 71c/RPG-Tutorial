using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeCntroller : MonoBehaviour {

	public float speed;
	private Rigidbody2D rigidbody;
	private bool isMoving;
	public float timeBetweenMove;
	private float timeBetweenMoveCounter;
	public float timeToMove;
	private float timeToMoveCounter;
	private Vector3 moveDirection;

	public float timeToReload;
	private bool isReloading;
	private GameObject player;
    
	void Start () {
		rigidbody = GetComponent<Rigidbody2D>();
		//timeBetweenMoveCounter = timeBetweenMove;
		//timeToMoveCounter = timeToMove;

		timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
		timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeToMove * 1.25f);
	}
	
	void Update () {
		if (isMoving) {
			timeToMoveCounter -= Time.deltaTime;
			rigidbody.velocity = moveDirection;

			if (timeToMoveCounter < 0) {
				isMoving = false;
				//timeBetweenMoveCounter = timeBetweenMove;
				timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
				rigidbody.velocity = Vector2.zero;
			}
		} else {
			timeBetweenMoveCounter -= Time.deltaTime;
			if (timeBetweenMoveCounter < 0) {
				isMoving = true;
				//timeToMoveCounter = timeToMove;
				timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeToMove * 1.25f);
				moveDirection = new Vector3(Random.Range(-1f, 1f) * speed, Random.Range(-1f, 1f) * speed, 0f);
			}
		}
        
		if (isReloading) {
			timeToReload -= Time.deltaTime;
			if (timeToReload < 0) {
				Application.LoadLevel(Application.loadedLevel);
				player.SetActive(true);
			}
		}
	} 

	private void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.name == "Player") {
			collision.gameObject.SetActive(false);
			isReloading = true;
			player = collision.gameObject;
		}
	}
}
