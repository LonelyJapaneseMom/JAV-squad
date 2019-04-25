using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class buttonscript14 : MonoBehaviour {

	public Button button;
	public AudioClip correctSound;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeColor() {
		float r = Random.Range (0f, 0f);
		float g = Random.Range (1f, 1f);
		float b = Random.Range (0f, 0f);
		ColorBlock colorVar = button.colors;
		colorVar.highlightedColor = new Color (r, g, b);
		button.colors = colorVar;
		scorecounter.score += 10;
		StartCoroutine (Correct6());
		if (button == true) {
			audioSource = GetComponent<AudioSource>();
			audioSource.clip = correctSound;
			audioSource.Play();
		}
	}

	public IEnumerator Correct6(){
		yield return new WaitForSeconds (1);
		SceneManager.LoadScene ("level 8");
	}
}
