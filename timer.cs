using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {

	public int timeLeft = 10;
	public Text countdown; 

	// Use this for initialization
	void Start () {
		StartCoroutine("LoseTime");
		Time.timeScale = 1f; 
	}
	
	// Update is called once per frame
	void Update () {
		countdown.text = ("Timer: " + timeLeft);
		if (timeLeft == 0) {
			SceneManager.LoadScene ("gameover");
		}
	}

	public IEnumerator LoseTime() {
		while (timeLeft > 0) {
			yield return new WaitForSeconds (1);
			timeLeft--;
		} 
	}
}
