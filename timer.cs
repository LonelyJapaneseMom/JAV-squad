using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {

	public int timeLeft = 10; // input for how many seconds
	public Text countdown; // input for the ui text
	public Button button; // input for the ui button

	// Use this for initialization
	void Start () {
		StartCoroutine("LoseTime"); // method for the count down timer
		Time.timeScale = 1; // the count down speed of the timer
	}
	
	// Update is called once per frame
	void Update () {
		countdown.text = ("" + timeLeft); // The string value this Text displays
		if (timeLeft == 0) { // Condition for the timer for when it reaches zero, the correct answer will be shown
			float r = Random.Range (0f, 0f); // this is a random range for the color red
			float g = Random.Range (1f, 1f); // this is a random range for the color green
			float b = Random.Range (0f, 0f); // this is a random range for the color blue

			ColorBlock colorVar = button.colors; // process of the input button
			colorVar.normalColor = new Color (r, g, b); // the color of the ui button will turn to green
			button.colors = colorVar; // process of the input ui button
			StartCoroutine (NextQuestion ()); // method for the when timer reaches zero, it switch to the next question
		} 
	}

	public IEnumerator NextQuestion() { // medthod for when the timer reaches zero, it will load next scene
		yield return new WaitForSeconds (2.5f); // delay time for before it load the next scene
		SceneManager.LoadScene ("level 2"); // this is for load the next scene
	}

	public IEnumerator LoseTime() { // method for the countdown speed of the timer
		while (timeLeft > 0) { // this is where the logic of the timer counting down
			yield return new WaitForSeconds (1); // delay time of the countdown
			timeLeft--; // this is the countdown timer 
		} 
	}
}
