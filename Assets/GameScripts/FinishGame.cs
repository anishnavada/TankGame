using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishGame : MonoBehaviour {

	private GameObject[] gObjects;
	private GameObject[] pObjects;
	private int score1;
	private int score2;
	public Text EndMessage;

	void Start () {
		StartCoroutine(EndGame(60));
	}
	
	IEnumerator EndGame (int seconds){
		yield return new WaitForSeconds(seconds);
		gObjects = GameObject.FindGameObjectsWithTag ("Wall");
		for (int i = 0; i < gObjects.Length; i++) {
			Destroy (gObjects [i]);
		}
		pObjects = GameObject.FindGameObjectsWithTag ("Player");
		for (int i = 0; i < pObjects.Length; i++) {
			Destroy (pObjects [i]);
		}
		GameObject PlayerOne = GameObject.Find ("Player1");
		Player1Movement script1 = PlayerOne.GetComponent<Player1Movement> ();
		GameObject PlayerTwo = GameObject.Find ("Player2");
		Player2Movement script2 = PlayerTwo.GetComponent<Player2Movement> ();
		score1 = script1.score;
		score2 = script2.score;
		if (score1 > score2) {
			EndMessage.text = "Player One won the game by " + (score1 - score2).ToString() + " points!";
		}
		if (score2 > score1) {
			EndMessage.text = "Player Two won the game by " + (score2 - score1).ToString () + " points!";
		}
	}
}
