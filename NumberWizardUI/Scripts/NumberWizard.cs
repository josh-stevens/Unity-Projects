using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// This program is a number guessing game, using a "binary search" algorithm

public class NumberWizard : MonoBehaviour {

int min;
int max;
int guess;
int maxGuessesAllowed = 10;

public Text text;

	// Use this for initialization
	void Start () {
		StartGame ();
	}
	
	void StartGame() {
		max = 1000;
		min = 1;
		guess = Random.Range (1,1001);
		text.text = guess.ToString ();
	
	}
	
	void NextGuess() {
		// Binary chop! Hi-yah!
		guess = (max + min) / 2;
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0){
			Application.LoadLevel("Win");
		}
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess ();
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess ();
	}
	
}
