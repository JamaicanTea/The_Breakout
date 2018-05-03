using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerActivator : MonoBehaviour {

	public GameObject lazer;
	Coroutine co;
	bool inTriggerZone = false;

	// Use this for initialization
	void OnTriggerEnter (Collider col) //sets a lazer trap to have delayed effect
	{
		StartCoroutine ("TimedLazer");
	}
	
	// Update is called once per frame
	IEnumerator TimedLazer() //turns on and off lazer
	{
			lazer.gameObject.SetActive (true);
		Debug.Log ("lazer on");
			yield return new WaitForSeconds (2);
			lazer.gameObject.SetActive (false);
		    yield return new WaitForSeconds (2);
		Debug.Log ("lazer off");
		StartCoroutine (TimedLazer()); //resets the function so it keeps on looping
		
	}
}
