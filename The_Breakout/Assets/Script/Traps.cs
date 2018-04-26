using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour {
	public BoxCollider collie;

	void OnTriggerEnter (Collider col) //if player passes through trap
	{
		if (col.CompareTag("Player"))
		{
			Debug.Log("Beep!");
		}
		else if (col.CompareTag("Box"))
		{
			collie.gameObject.SetActive (false);
		}
	}
	void OnTriggerExit (Collider col) //if player passes through trap
	{
		collie.gameObject.SetActive (true);
	}
}
