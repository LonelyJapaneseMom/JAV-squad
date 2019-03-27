using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buttonscript : MonoBehaviour {

	public Button button;

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
		scorecounter.score -= 100;
	}
}
