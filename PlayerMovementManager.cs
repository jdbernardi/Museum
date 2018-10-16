using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementManager : MonoBehaviour {

	public GameObject player;
	Vector3 t;

	void OnEnable()
	{
		OrbInteraction.OnClicked += MovePlayer;
	}

	void OnDisable()
	{
		OrbInteraction.OnClicked -= MovePlayer;
	}

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	void MovePlayer()
	{
		Debug.Log("Moving to: " + OrbInteraction.orbPosition);
		iTween.MoveTo(player, 
			iTween.Hash(
//				"position", OrbInteraction.orbPosition,
				"x", OrbInteraction.orbPosition.x,
				"y", OrbInteraction.orbPosition.y + 2,
				"z", OrbInteraction.orbPosition.z,
				"time", 2,
				"easetype", "linear"
			)
		);
	}
}
