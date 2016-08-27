using UnityEngine;
using System.Collections;

public class PlaySpace : MonoBehaviour {

	GameObject rig;

	// Use this for initialization
	void Start () {
		rig = GameObject.FindWithTag("CameraRig");
	}

	// Update is called once per frame
	void LateUpdate () {
		transform.position = new Vector3(rig.transform.position.x, 0, rig.transform.position.z);
	}

	void PlayAreaResolved (float size) {
		Debug.Log(size);
		transform.localScale = new Vector3(size / 1.3f, 0.1f, size / 1.3f);
	}
}
