using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour {

	private Animation anim;
	public GameObject door;
	private bool doorOpen = false;
	public string openClip, closeClip;

	void Start()
	{
		anim = GetComponent<Animation>();
	}

	public void OnDoorClicked()
	{
		if(doorOpen)
		{
			anim.Play(closeClip);
			doorOpen = false;
		} else {
			anim.Play(openClip);
			doorOpen = true;
		}
			
	}

	// Use this for initialization
	void Awake () {
//		Initiate.Fade("Main", Color.blue, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
