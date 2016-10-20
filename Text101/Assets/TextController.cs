using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text mytext;
	public int mindex = 0;
	public string[] menu = {"start game","quit"};
	public enum lollol {asdf,ghgj,fgh};
	public lollol states;

	// Use this for initialization
	void Start () {

	}

	void onKeyPressDo(float kc int func){
		if(Input.GetKeyDown(kc)){
			int lol;
			lol
			func();
		}
	}

	// Update is called once per frame

	void Update ()
	{
		onKeyPressDo(KeyCode.S, new int(){print("ay it works lmao")})
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			mindex = 0;
			mytext.text = menu [mindex];
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			mindex = 1;
			mytext.text = menu [mindex];
		}
	}
}
