using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveTheCube : MonoBehaviour {
	
	public bool ToTheLeft = false;
	public bool ToTheRight = false;
	public bool ToJump = false;
	public bool IsJumping = false;
	public float MaxRange = 0;
	public float jumpHeight = 500;
	public Vector2 direction;
	public static float limit_speed = 4;
	public float speed_to_right = 5f;
	public float speed_to_left = -5f;

	void FixedUpdate()
	{
		if (ToTheLeft == true)
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed_to_left, gameObject.GetComponent<Rigidbody2D> ().velocity.y);
		if (ToTheRight == true)
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed_to_right, gameObject.GetComponent<Rigidbody2D> ().velocity.y);
	}
	/*
	//void Update()
	//{
	//	float move = Input.GetButton ("Horizontal");
	//	if (transform.position.y < -10)
	//		Application.LoadLevel (Application.loadedLevel);
	//	gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * 10f, gameObject.GetComponent<Rigidbody2D> ().velocity.y);
		/*
		if (ToTheRight == true) {
			gameObject.GetComponent<Rigidbody2D> ().AddForce (GoRight);
			if (gameObject.GetComponent<Rigidbody2D> ().velocity.magnitude > limit_speed)
				gameObject.GetComponent<Rigidbody2D> ().velocity = gameObject.GetComponent<Rigidbody2D> ().velocity.normalized * limit_speed;
		}
		if (ToTheLeft == true) {
			gameObject.GetComponent<Rigidbody2D> ().AddForce (GoLeft);
			if (gameObject.GetComponent<Rigidbody2D> ().velocity.magnitude > limit_speed) {
				gameObject.GetComponent<Rigidbody2D> ().velocity = gameObject.GetComponent<Rigidbody2D> ().velocity.normalized * limit_speed;
		}
		if (ToJump == true && IsJumping == false) {
			gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * jumpHeight);
			ToJump = false;
			IsJumping = true;
		}
	}
*/
		
	public void JumpToTheEdge()
	{
		if (ToJump == false)
		{
			ToTheLeft = false;
			ToTheRight = false;
			ToJump = true;
		}
		else
			ToJump = false;
	}
	public void MoveToRight()
	{
		if (ToTheLeft == true)
			ToTheLeft = false;
		
		if (ToTheRight == true)
			ToTheRight = false;
		else
			ToTheRight = true;
	}

	public void MoveToLeft()
	{
		if (ToTheRight == true)
			ToTheRight = false;
		
		if (ToTheLeft == true)
			ToTheLeft = false;
		else
			ToTheLeft = true;
	}

	public void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "ground")
			IsJumping = false;
	}
}
