using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {

	// Use this for initialization
	public void ReturnMenu () 
	{
		SceneManager.LoadScene ("Title Screen");
	}
	
	// Update is called once per frame
	public void NextLevel () 
	{
		SceneManager.LoadScene ("GameScene2");
	}

	public void Play ()
	{
		SceneManager.LoadScene ("GameScene1");
	}

	public void PlayLevel2 ()
	{
		SceneManager.LoadScene ("GameScene2");
	}

	public void Quit ()
	{
		Application.Quit();
	}
}
