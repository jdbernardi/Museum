using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class narrateButtonUI : MonoBehaviour {

	public Material _normalMaterial, _hoverMaterial, _onClickMaterial;
	Renderer rend;

	// Use this for initialization
	void Start () 
	{
		rend = GetComponent<Renderer>();
		rend.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void OnHover()
	{
		rend.material = _hoverMaterial; 
		print("Hovering");
	}

	public void OnClick()
	{
		rend.material = _onClickMaterial; 
		print("Click");

	}

	public void OnExit()
	{
		rend.material = _normalMaterial; 
		print("Exit");

	}

	void print(string str)
	{
		Debug.Log(str);
	}

}
