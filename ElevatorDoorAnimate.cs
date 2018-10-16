using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoorAnimate : MonoBehaviour {

	private Animation anim;
	private static bool doorOpen = false;
	public string open, close;

	void Start()
	{
		anim = GetComponent<Animation>();
	}

	void OnEnable()
	{
		ElevatorButton.OnClicked += AnimateDoor;
	}

	void OnDisable()
	{
		ElevatorButton.OnClicked -= AnimateDoor;
	}

	public void AnimateDoor()
	{
		Debug.Log("Animate Door");
		if(doorOpen)
		{
			anim.Play(close);
			doorOpen = false;
		} else {
			anim.Play(open);
			doorOpen = true;
		}
			
	}


}
