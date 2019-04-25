using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenubutton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void GoMainMenu(){
		StartCoroutine (MainMenu()); // method for ui button to load a new scene
	}

	public IEnumerator MainMenu() { // Starts a Coroutine named coroutine or any name.
		yield return new WaitForSeconds (1); // Suspends the coroutine execution for the given amount of seconds using scaled time
		SceneManager.LoadScene ("mainmenu"); // for the ui button to load a new scene
	}
}

