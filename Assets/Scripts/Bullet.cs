using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 20f;
	public int damage = 40;
	public Rigidbody2D rb;
	public GameObject impactEffect;

	public float TimeLeft = 1;

	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * speed;
	}

	void Update(){
		TimeLeft -= Time.deltaTime;
		if (TimeLeft < 0){
			Destroy(gameObject);
		}
	}
	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		Enemy enemy = hitInfo.GetComponent<Enemy>();
		if (enemy != null)
		{
			enemy.TakeDamage(damage);
			Destroy(gameObject);
		}
		
		//Instantiate(impactEffect, transform.position, transform.rotation);

		
	}
	
}
