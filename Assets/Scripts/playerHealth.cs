using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour {
    public gameOverScreen gameOverScreen;
	public int health;
	public int maxHealth = 50;

	public GameObject Player;

	// Use this for initialization
	void Start () {
		health = maxHealth;	
	}

	public void TakeDamage(int amount){
		health -= amount;
		if(health <= 0){
			gameOverScreen.Setup(scoreScript.scoreValue);
			Player.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
