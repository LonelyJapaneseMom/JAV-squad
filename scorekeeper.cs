using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
internal class ValuesHolder{
	internal static int scorecount = 0;
}
public class scorekeeper : MonoBehaviour {

	public static int count;
	public Text countText;

	// Use this for initialization
	void Start () {
		count = scorecounter.score;
		SetCountText ();
	}

	void SetCountText(){
		count = ValuesHolder.scorecount++;
		countText.text = "Your Score is: " + scorecounter.score.ToString ();
	}

	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad (countText);
	}
}