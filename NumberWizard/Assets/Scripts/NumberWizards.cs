using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	int max = 1000;
	int min = 1;

	// Use this for initialization
	void Start () {
		print("==Number Wizard==");
		print("Pick a random number");
		print("The highest number you can pick is " + max);
		print("The lowset number you can pick is " + min);

	}

	void StartGame(){
		
	}

	// Update is called once per frame
	void Update () {
	if(Input.GetKeyDown(KeyCode.DownArrow)){
		print("down arrow pressed");
	}
	if(Input.GetKeyDown(KeyCode.UpArrow)){
		print("up arrow pressed");
	}
	}
}
