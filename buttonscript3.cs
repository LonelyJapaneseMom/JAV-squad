using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class buttonscript3 : MonoBehaviour {

	public Button button; // input for the ui button
	public AudioClip correctSound; // input for the audio clip
	private AudioSource audioSource; // A representation of audio sources in 3D or 2D

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeColor() { // method for the the ui button to change its color
		float r = Random.Range (0f, 0f); // this is an input of a random range for color red
		float g = Random.Range (1f, 1f); // this is an input of a random range for color green
		float b = Random.Range (0f, 0f); // this is an input of a random range for color blue

		ColorBlock colorVar = button.colors; // process for the input of the ui button
		colorVar.highlightedColor = new Color (r, g, b); // process for the colorvar to change color
		button.colors = colorVar; // process for the ui button
		scorecounter.score += 10; // this for the ui text score when the ui button is clicked, it will add points to the ui text score
		StartCoroutine (YouWin()); // method for the ui button to load the next scene after being clicked

		if (button == true) { // condition for the when the ui button is clicked, it will play the sound effect
			audioSource = GetComponent<AudioSource>(); // Fetch the AudioSource from the GameObject
			audioSource.clip = correctSound; // A container for audio data
			audioSource.Play(); // Play the audio you attach to the AudioSource component
		}
	}

	public IEnumerator YouWin() { // method for the ui button to load new scene 
		yield return new WaitForSeconds (1); // Suspends the coroutine execution for the given amount of seconds using scaled time
		SceneManager.LoadScene ("youwin"); // for the ui button to load a new scene
	}
}
