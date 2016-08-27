using UnityEngine;
using System.Collections;

public class VibrateOnTrigger : MonoBehaviour {

	float timeToVibrate = 1;
	float vibrateTime = 0;
	bool vibrating = false;
	
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (vibrating) {
			SteamVR_Controller.Input(1).TriggerHapticPulse(3999);
			SteamVR_Controller.Input(4).TriggerHapticPulse(3999);

			vibrateTime += Time.deltaTime;

			if (vibrateTime >= timeToVibrate) {
				vibrating = false;
				vibrateTime = 0;
			}
		}
	}

	void OnTriggerEnter (Collider collider) {
		vibrating = true;
	}
}
