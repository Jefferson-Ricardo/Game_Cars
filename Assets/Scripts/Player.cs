using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Rigidbody2D rb;
	public float Speed = 4f;

	public GameObject ExplosionObject;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	

	void FixedUpdate () {
		Vector2 dir = Vector2.zero;

		if (Input.GetKey (KeyCode.LeftArrow)) {
			dir.x = -1;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			dir.x = 1;
		}

		rb.velocity = dir * Speed;
	}

	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.CompareTag ("Carros")) {
			GameObject.Instantiate (ExplosionObject, this.transform.position, Quaternion.identity);
			GameObject.Destroy (this.gameObject);
		}
	
	
	
	
	}


}
