using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbInteraction : MonoBehaviour {

	public Material _normalMaterial, _hoverMaterial, _onClickMaterial;
	Renderer rend;
	public GameObject panel;
	public static Vector3 orbPosition;

	//set up event for movement that iTween can subscribe to 
	public delegate void ClickAction();
	public static event ClickAction OnClicked; 

	// Use this for initialization
	void Start () 
	{
		rend = GetComponent<Renderer>();
		rend.enabled = true;

		if(panel != null)
			panel.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
	}

	public void OrbClicked()
	{
		orbPosition = this.transform.position;
		if(panel != null)
			Invoke("ShowPanel", 1.5f);
		if(OnClicked != null)
			OnClicked();
	}

	public void OnHover()
	{
		rend.material = _hoverMaterial; 
		print("Hover");
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

	void ShowPanel()
	{
		panel.SetActive(true);
	}
}
