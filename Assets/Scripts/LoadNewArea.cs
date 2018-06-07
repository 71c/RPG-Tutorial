using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewArea : MonoBehaviour {

	public string levelToLoad;

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.name == "Player") {
			Application.LoadLevel(levelToLoad);
		}
	}
}
