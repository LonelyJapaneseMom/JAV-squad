﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class buttonscript9 : MonoBehaviour {

	public Button button;
	public AudioClip wrongSound;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	public void ChangeColor() {
		float r = Random.Range (1f, 1f);
		float g = Random.Range (0f, 0f);
		float b = Random.Range (0f, 0f);
		ColorBlock colorVar = button.colors;
		colorVar.highlightedColor = new Color (r, g, b);
		button.colors = colorVar;
		StartCoroutine (GameOver4());
		if (button == true) {
			audioSource = GetComponent<AudioSource>();
			audioSource.clip = wrongSound;
			audioSource.Play();
		}
	}

	public IEnumerator GameOver4(){
		yield return new WaitForSeconds (1);
		SceneManager.LoadScene ("level 6");
	}
}
