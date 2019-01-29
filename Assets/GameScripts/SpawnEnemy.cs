using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

	public GameObject enemy;
	private GameObject newEnemy;
	public int maxNumberOfEnemies = 5;
	public static int currentEnemies = 0;
	public float randomNum = -100;
	public float x = -100;
	public float y = -100;
	public static Vector3[] locations;
	public Vector3 randomPos;

	// Use this for initialization
	void Start () {
		locations = new Vector3[] {
			new Vector3 (5, 17, 0),
			new Vector3 (11, 17, 0),
			new Vector3 (16.75f, 17, 0),
			new Vector3 (22.77f, 17, 0),
			new Vector3 (28.67f, 17, 0)
		};
		spawn (locations [0]);
		spawn (locations [1]);
		spawn (locations [2]);
		spawn (locations [3]);
		spawn (locations [4]);
	}

	void spawn(Vector3 randomPos){
		//randomPos = locations [(int)(5 * Random.value)];
		Debug.Log ("x" + x + " y" + y);
		newEnemy = (GameObject)Instantiate(enemy, randomPos, Quaternion.identity);
		currentEnemies += 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentEnemies < maxNumberOfEnemies) {
			spawn (locations [(int)(5 * Random.value)]);
			currentEnemies += 1;
		}
		
	}
}
