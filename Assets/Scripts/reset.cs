using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class reset : MonoBehaviour {
	public gameOverScreen gameOverScreen;
	//public scoreScript scoreScript;

	void OnTriggerEnter2D (Collider2D other) {
		GameOver();
		//SceneManager.LoadScene("1");
	}

	public void GameOver(){
		gameOverScreen.Setup(scoreScript.scoreValue);
	}
}
