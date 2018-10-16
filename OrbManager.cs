using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbManager : MonoBehaviour {

	public GameObject orb;

	// Use this for initialization
	void Start () {
		orb.SetActive(true);
	}

	void OnEnable()
	{
		OrbInteraction.OnClicked += HideOrb;
	}

	void OnDisable()
	{
		OrbInteraction.OnClicked -= HideOrb;
	}


	void HideOrb()
	{
		orb.SetActive(false);
	}

}
