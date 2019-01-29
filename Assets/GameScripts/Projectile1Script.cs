using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile1Script : MonoBehaviour {



	void Start(){
		
	}

	void OnCollisionEnter2D(Collision2D other){
		GameObject PlayerOne = GameObject.Find ("Player1");
		Player1Movement script = PlayerOne.GetComponent<Player1Movement> ();
		GameObject explode = (GameObject)Instantiate (Resources.Load("Explode"), gameObject.transform.position, gameObject.transform.rotation);
		GameObject explodingSound = (GameObject)Instantiate (Resources.Load ("ExplodingSound"), gameObject.transform.position, gameObject.transform.rotation);
		Destroy (gameObject);
		Destroy (explode,3f);
		Destroy (explodingSound, 3f);

		if (other.gameObject.tag == "Player"){
			script.score += 3;
	
		}
		if (other.gameObject.name.Contains ("Enemy")) {
			Debug.Log ("destroying enemy");
			script.score += 1;
		}
	}



}
