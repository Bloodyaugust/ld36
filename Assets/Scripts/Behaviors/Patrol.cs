using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {

	float currentPos = 0;
	float directionModifier = 1;

	// Use this for initialization
	void Start () {
		currentPos = Mathf.Acos(transform.position.x);

		if (Random.value >= 0.5f) {
			directionModifier = -1;
		}
	}

	// Update is called once per frame
	void Update () {
		currentPos += Time.deltaTime * directionModifier;

		transform.position = new Vector3(Mathf.Cos(currentPos) * 1.5f, transform.position.y, transform.position.z);
	}
}
