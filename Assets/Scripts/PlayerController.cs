using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;

	void Start () {
		
	}

	void Update () {
		float unit = moveSpeed * Time.deltaTime;
		transform.Translate(new Vector2(Input.GetAxisRaw("Horizontal") * unit, Input.GetAxisRaw("Vertical") * unit));
	}
}
