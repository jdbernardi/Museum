using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public string scene;

	// Use this for initialization
	void Start () {
		
	}
		
	// Update is called once per frame
	void Update () {
		
	}

	public void CloseElevator()
	{
		Invoke("LoadLevel", 3f);
	}

	public void LoadLevel(){
		SceneManager.LoadScene(scene);
	}
}
