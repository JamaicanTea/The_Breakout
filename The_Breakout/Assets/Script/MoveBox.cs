using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour {
	public Rigidbody box;
	public Transform player;
	public bool pushBox = false;
	public bool pullBox = false;

	void Start()
	{
		box = GetComponent<Rigidbody> ();	
	}

	void OnCollisionEnter (Collision col) 
	{
		if(col.gameObject.tag == "Player")
		{
			player = col.gameObject.transform;
			box.isKinematic = false;
			box.AddForce (-Vector3.forward);
			pushBox = true;
			Debug.Log("push!");
		}
	}
	void OnCollisionExit (Collision col)
	{
		pushBox = false;
		box.velocity = Vector3.zero;
		box.isKinematic = true;
		Debug.Log ("stop");
	}
	void OnCollisionStay (Collision col)
	{
		if (col.gameObject.tag == "Player" && Input.GetKeyDown (KeyCode.Space)) {
			//box.isKinematic = true;
			//box.AddForce (-Vector3.back);
			pullBox = true;
			Debug.Log ("pull!");
		}
	}
	void Update()
	{
		if(pullBox)
		{
			//box.isKinematic = false;
			//box.AddForce (-Vector3.back);
			transform.position = player.position;
			Debug.Log ("pull!");
			if (Input.GetKeyUp(KeyCode.Space))
			{
				pullBox = false;
			}
		}

	}
}
