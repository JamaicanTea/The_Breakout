using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {
	public GameObject winUI;

	// Use this for initialization
	void OnTriggerEnter (Collider col) //if player finishes the level, opens up winning UI
	{
		if(col.CompareTag("Player"))
		{
			Time.timeScale = 0;
			Debug.Log ("Level Clear!");
			winUI.gameObject.SetActive (true);

		}
		
	}

}
