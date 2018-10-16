using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButton : MonoBehaviour {

	public delegate void ClickAction();
	public static event ClickAction OnClicked;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ElevatorButtonPressed()
	{
		if(OnClicked != null)
		{
			OnClicked();
		}
	}

}
