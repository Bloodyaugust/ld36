using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {

	public Camera followCamera;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.position = followCamera.transform.position;
	}
}
