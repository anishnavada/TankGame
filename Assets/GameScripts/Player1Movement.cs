using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Player1Movement : MonoBehaviour {

	public float speed = 1.0f;             //Floating point variable to store the player's movement speed.
	public GameObject projectile; //Store a reference to the Rigidbody2D component required to use 2D Physics.
	public string direction="";
	public int score;
	public Text Score;

	// Use this for initialization
	void Start()
	{
		score = 0;
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name.Contains("Projectile")){
			score -= 1;
			transform.position = new Vector2 (0.95f, 1.01f);
		}
	}
		
	void Update()
	{
		Score.text = "Player_One Score: " + score.ToString ();
		Debug.Log (transform.forward);

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
			direction="left";
		}

		else if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
			direction="right";
		}
			

		else if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.up * speed * Time.deltaTime;
			direction="up";
		}
			

		else if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += Vector3.down * speed * Time.deltaTime;
			direction="down";
		}


		if (Input.GetKeyDown(KeyCode.RightControl)) {
			GameObject bullet = (GameObject)Instantiate(projectile, transform.position, Quaternion.identity);
			Rigidbody2D bull = bullet.GetComponent<Rigidbody2D> ();
			if (bullet != null && direction == "up") {
				bull.velocity = (Vector2.up * 10);
			}
			if (bullet != null && direction == "down") {
				bull.velocity = (Vector2.down * 10);
			}
			if (bullet != null && direction == "right") {
				bull.velocity = (Vector2.right * 10);
			}
			if (bullet != null && direction == "left") {
				bull.velocity = (Vector2.left * 10);
			}

		}
	
	}

}