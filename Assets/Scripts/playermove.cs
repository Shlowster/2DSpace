using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour {

	public float moveSpeed;
	public float boostSpeed;
	public float tempSpeed;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		tempSpeed = moveSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("moveSpeed is ," + moveSpeed);
		//Debug.Log("tempSpeed is ," + tempSpeed);
		if (Input.GetKey(KeyCode.A)){
			GetComponent<SpriteRenderer>().flipX = true;
			rb.velocity = new Vector2 (-moveSpeed,rb.velocity.y);
		}
		if (Input.GetKey(KeyCode.D)){
			GetComponent<SpriteRenderer>().flipX = false;
			rb.velocity = new Vector2 (moveSpeed,rb.velocity.y);
		}

		if (Input.GetKey(KeyCode.W)){
			rb.velocity = new Vector2 (rb.velocity.x,moveSpeed/4);
		}
		if (Input.GetKey (KeyCode.S)) {
			rb.velocity = new Vector2 (rb.velocity.x, -moveSpeed/4);
		}

		if (Input.GetKey (KeyCode.LeftShift)) {
			// Immediate Boost
			//moveSpeed = boostSpeed;

			// Gradual Boost
			moveSpeed+=1;
			if (moveSpeed > boostSpeed){
				moveSpeed = boostSpeed;
			}
		}

		if (Input.GetKeyUp (KeyCode.LeftShift)) {
			moveSpeed = tempSpeed;
		}


	}
}
