using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxUnlock : MonoBehaviour {
	public GameObject targetDoor;


	void OnTriggerEnter (Collider col) //if a box is placed in this game object, the doors open
	{
		if(col.CompareTag("Box"))
		{
			targetDoor.SetActive (false);
		}
		
	}
}
