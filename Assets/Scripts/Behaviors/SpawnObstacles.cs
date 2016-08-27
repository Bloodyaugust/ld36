using UnityEngine;
using System.Collections;

public class SpawnObstacles : MonoBehaviour {

	public GameObject	obstaclePrefab;
	public GameObject spawnTarget;

	float heightMax = 2;
	float heightMin = 0;
	float lastSpawn = 0;
	float spawnDistance = 110;
	float spawnInterval = 3;
	float widthMax = 1;
	float widthMin = -1;
	int spawns = 0;
	int spawnsUntilPatrol = 5;

	void SpawnObstacle () {
		Vector3 position = new Vector3(0, 0, spawnTarget.transform.position.z + spawnDistance);

		position.x = Random.Range(widthMin, widthMax);
		position.y = Random.Range(heightMin, heightMax);

		GameObject newObstacle = (GameObject)Object.Instantiate(obstaclePrefab, position, Quaternion.identity);

		if (spawns >= spawnsUntilPatrol && Random.value >= 0.5) {
			newObstacle.AddComponent<Patrol>();
		}

		spawns++;
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		lastSpawn += Time.deltaTime;

		if (lastSpawn >= spawnInterval) {
			SpawnObstacle();
			lastSpawn = 0;
		}
	}
}
