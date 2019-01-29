using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour {

	public GameObject projectile;
	private Vector2[] directions;
	private Vector2[] places;
	private Vector2 direction;
	private float speed = 5.0f;
	private static Rigidbody2D rb;
	private GameObject bullet;
	private Rigidbody2D bull;
	private List<int> n;
	private int r;

	// Use this for initialization
	void Start () {
		/*players = GameObject.FindGameObjectsWithTag ("Player");
		if (Vector3.Distance (transform.position, players [0].transform.position) < Vector3.Distance (transform.position, players [1].transform.position)) {
			target = players [0];
		} else {
			target = players [1];
		}*/
		n = new List<int> ();
		n.Add (0);
		n.Add (1);
		n.Add (2);
		n.Add (3);
		rb = GetComponent<Rigidbody2D> ();
		Debug.Log(Random.value);
		directions = new Vector2[] {new Vector2(1,0),new Vector2(-1,0),new Vector2(0,-1),new Vector2(0,1)};
		places = new Vector2[] {new Vector2(28.60378f, 17.59906f), new Vector2(16.2f,31.6f), new Vector2(22.9f,8.5f), new Vector2(13.3f,5.8f), new Vector2(4.8f,16.5f),new Vector2(30.9f,32.4f)};
		r = (int)(Random.value * 4);
		direction = directions [r];
		//rb.velocity = direction * speed;
		Debug.Log (direction);
	}

	void OnCollisionEnter2D(Collision2D other){


		if (other.gameObject.name.Contains ("Wall")) {
			Debug.Log ("rotating");
			n.Remove (r);
			r = Random.Range (0, n.Count);
			direction = directions [r];
			n.Clear();
			n.Add (0);
			n.Add (1);
			n.Add (2);
			n.Add (3);
		} else if (other.gameObject.name.Contains("Projectile")) {
			Debug.Log ("destroying");
			transform.position = places[Random.Range(0,6)];
		}
			
	}

	/*IEnumerator wait()
	{
		print(Time.time);
		yield return new WaitForSeconds(1000);
		bullet = (GameObject)Instantiate(projectile, transform.position, Quaternion.identity);
		bullet.AddComponent<ProjectileScript2>();
		bull = bullet.GetComponent<Rigidbody2D> ();
		bull.velocity = direction * 10;
		print(Time.time);
	}*/

	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad > 5.0f) {
	//	direction = target.transform.position - transform.position;
		//	direction = direction / direction.magnitude;
		/*if (Vector2.Distance (prevPos, transform.position) == 0) {
			direction = directions [(int)(Random.value * 4)];
			Debug.Log (direction);
		}*/
		Debug.Log (transform.forward);
		rb.velocity = direction * speed;
	//rb.velocity = new Vector2(transform.forward[0],transform.forward[2]) * speed;
		//rb.velocity = new Vector2(direction.x * speed,direction.y*speed);
		}
		}
}
