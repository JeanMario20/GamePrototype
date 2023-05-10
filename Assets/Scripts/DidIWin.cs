using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DidIWin : MonoBehaviour {
	public gameOverScreen gameOverScreen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(scoreScript.scoreValue == 80){
			gameOverScreen.Setup(scoreScript.scoreValue);
		}
	}
}
