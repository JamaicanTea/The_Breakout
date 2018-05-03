using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	public Rigidbody rb;
	public float moveSpeed = 10f;
	public bool moveForward = false;
	public bool moveBackward = false;
	public bool moveLeft = false;
	public bool moveRight = false;
	// Use this for initialization
	void Awake () //resets the game when either UI pops out and buttons were pressed
	{
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () //mostly player movements
	{
		if (Input.GetKey (KeyCode.UpArrow)) { //if the arrow is pressed, it activates a bool corresponding to the direction it was moving.
			moveForward = true;
			rb.velocity = -Vector3.forward* moveSpeed;
		} 
		else //disables the bool whenever the button is released
		{
			moveForward = false;
		}
		if (moveForward == false) //stops player after movement button is released
		{
			rb.velocity = Vector3.zero;
		}

		if (Input.GetKey (KeyCode.DownArrow)) { //moves player backwards
			moveBackward = true;
			rb.velocity = -Vector3.back* moveSpeed;
		} 
		else //disables the bool whenever the button is released
		{
			moveBackward = false;

		}
		if (moveBackward = false) //moves character whenever the direction bool is true
		{
			rb.velocity = Vector3.zero;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) { //moves player to the left
			moveLeft = true;
			rb.velocity = -Vector3.left* moveSpeed;
		} 
		else //disables the bool whenever the button is released
		{
			moveLeft = false;

		}
		if (moveLeft = false) //moves character whenever the direction bool is true
		{
			rb.velocity = Vector3.zero;
		}

		if (Input.GetKey (KeyCode.RightArrow)) { //moves player to the Right
			moveRight = true;
			rb.velocity = -Vector3.right* moveSpeed;
		} 
		else //disables the bool whenever the button is released
		{
			moveRight = false;

		}
		if (moveRight = false) //moves character whenever the direction bool is true
		{
			rb.velocity = Vector3.zero;
		}
	}
}
