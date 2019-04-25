using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer9 : MonoBehaviour {

	public int timeLeft = 10;
	public Text countdown;
	public Button button;

	// Use this for initialization
	void Start () {
		StartCoroutine("LoseTime");
		Time.timeScale = 1; 
	}
	
	// Update is called once per frame
	void Update () {
		countdown.text = ("" + timeLeft);
		if (timeLeft==0) {
			float r = Random.Range (0f, 0f);
			float g = Random.Range (1f, 1f);
			float b = Random.Range (0f, 0f);
			ColorBlock colorVar = button.colors;
			colorVar.normalColor = new Color (r, g, b);
			button.colors = colorVar;
			StartCoroutine (NextQuestion());
		}
	}

	public IEnumerator NextQuestion() {
		yield return new WaitForSeconds (2.5f);
		SceneManager.LoadScene ("gameover");
	}

	public IEnumerator LoseTime() {
		while (timeLeft > 0) {
			yield return new WaitForSeconds (1);
			timeLeft--;
		} 
	}
}
