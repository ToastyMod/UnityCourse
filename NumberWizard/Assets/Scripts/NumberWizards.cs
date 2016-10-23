using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	int max = 999;
	int min = 0;
	int guess = 0;
	int guesses = 0;

	// Use this for initialization
	void Start () {
	StartGame();
	}

	void StartGame(){
		int max = 999;
	int min = 0;
	int guess = 0;
	int guesses = 0;
	print("==Number Wizard==");
	print("Pick a random number between "+min+" and "+max);
	print("====================");
	guess = ((max * min)/2);

	NextGuess();

	max++;
	}

	void NextGuess(){
		print("Is the number higher or lower than "+guess+"?");
		guesses++;
	}

	// Update is called once per frame
	void Update () {
	if(guesses == 10){
		print("========");
		print("YOU WIN");
		print("========");
		StartGame();
	}
	if(Input.GetKeyDown(KeyCode.DownArrow)){
		max = guess;
		NextGuess();
	}
	if(Input.GetKeyDown(KeyCode.UpArrow)){
		min = guess;
		NextGuess();
	}
	if(Input.GetKeyDown(KeyCode.Return)){
		print("==============");
		print("   YOU LOSE   ");
		print("==============");
		StartGame();
	}
	}
}
