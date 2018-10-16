using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManager : MonoBehaviour {

	public GameObject panel;

	// Use this for initialization
	void Start () {
		panel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
    {
			Debug.Log("Contact with " +  col.gameObject.name);
			panel.SetActive(true);
    }

    void OnTriggerExit(Collider col)
    {
    	panel.SetActive(false);

    }

}