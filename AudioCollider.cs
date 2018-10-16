using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollider : MonoBehaviour {

	private GvrAudioSource audio;
	private bool isPlaying;

	// Use this for initialization
	void Start () {
		audio = GetComponent<GvrAudioSource>();
		isPlaying = false;
	}
	
    void OnTriggerEnter(Collider col)
    {
    	Debug.Log("TRigger enter");
    	audio.Play();
    }

	void OnTriggerExit(Collider col)
    {
    	Debug.Log("TRigger enter");
    	audio.Stop();
    }

    public void Clicked() {
    	if(isPlaying == false)
    	{
    		audio.Play();
    		isPlaying = true;
    	} else {
    		audio.Stop();
    		isPlaying = false;
    	}
    }

	void OnCollisionEnter(Collision col)
    {
    	Debug.Log("Collision enter");
    }

	void OnCollisionExit(Collision col)
    {
    	Debug.Log("Collision exit");
    }

	void OnColliderEnter(Collider col)
    {
    	Debug.Log("Collider enter");
    }

	void OnColliderExit(Collider col)
    {
    	Debug.Log("Collider exit");
    }


}