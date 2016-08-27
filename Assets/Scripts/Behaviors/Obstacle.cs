using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	bool destroyed = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (!destroyed) {

		} else {
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter (Collider collider) {
		if (collider.gameObject.tag == "Player") {
			destroyed = true;
		}
	}
}
