using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour {
	public BoxCollider collie;
	public GameObject goUI;

	void OnTriggerEnter (Collider col) //if player passes through trap
	{
		if (col.CompareTag("Player"))
		{
			Debug.Log("Beep!");
			GameOver ();
		}
		else if (col.CompareTag("Box"))
		{
			collie.gameObject.SetActive (false);
		}
	}

	void GameOver()
	{
		Time.timeScale = 0;
		goUI.gameObject.SetActive (true);
	}
}
