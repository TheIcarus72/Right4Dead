using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHover : MonoBehaviour {
	public GameObject startButton;
	public Sprite startIMG1, startIMG2;

		
	void OnMouseEnter() {
		startButton.GetComponent<SpriteRenderer> ().sprite = startIMG2;
	}
	void OnMouseExit() {
		startButton.GetComponent<SpriteRenderer> ().sprite = startIMG1;
	}

	void OnMouseDown() {
		SceneManager.LoadScene("_Complete-Game");
	}
}
