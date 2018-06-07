using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float moveSpeed;
	private Animator animator;
	private Rigidbody2D rigidbody;
	private bool isMoving;
	private Vector2 lastMove;

	private static bool playerExists;

	void Start () {
		animator = GetComponent<Animator>();
		rigidbody = GetComponent<Rigidbody2D>();

		if (! playerExists) {
			playerExists = true;
			DontDestroyOnLoad(transform.gameObject);
		} else {
			Destroy(gameObject);
		}
	}

	void Update () {
		float moveX = Input.GetAxisRaw("Horizontal");
		float moveY = Input.GetAxisRaw("Vertical");
		float unit = moveSpeed;
        
		rigidbody.velocity = new Vector2(moveX * unit,moveY * unit);

		isMoving = Mathf.Abs(moveX) + Mathf.Abs(moveY) > 0;
		if (isMoving)
			lastMove = new Vector2(moveX, moveY);
        
		animator.SetFloat("moveX", moveX);
		animator.SetFloat("moveY", moveY);

		animator.SetBool("isMoving", isMoving);

		animator.SetFloat("lastMoveX", lastMove.x);
		animator.SetFloat("lastMoveY", lastMove.y);
	}
}
