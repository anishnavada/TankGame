using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearButtons : MonoBehaviour {

	private List<GameObject> gObjects;

	void Start(){
		StartCoroutine(RemoveAfterSeconds(5));
	}

	IEnumerator RemoveAfterSeconds (int seconds){
		yield return new WaitForSeconds(seconds);
		Destroy (gameObject);
	}
	}