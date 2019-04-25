using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecounter : MonoBehaviour {

	public static int score; // input for the ui text score in the inspector window
	Text text; // declare of ui text

	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> (); // The string value this Text displays.
		score = 0; // initialize the ui text
	}

	// Update is called once per frame
	void Update () {
		text.text = "" + score; // The string value this Text displays.
	}
}
