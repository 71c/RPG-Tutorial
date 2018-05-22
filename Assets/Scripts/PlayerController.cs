﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float moveSpeed;
	private Animator animator;
	private bool isMoving;
	private Vector2 lastMove;

	void Start () {
		animator = GetComponent<Animator>();
	}

	void Update () {
		float moveX = Input.GetAxisRaw("Horizontal");
		float moveY = Input.GetAxisRaw("Vertical");
		float unit = moveSpeed * Time.deltaTime;
		transform.Translate(new Vector2(moveX * unit, moveY * unit));
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
