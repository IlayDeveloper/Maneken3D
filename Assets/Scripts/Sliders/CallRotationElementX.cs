using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallRotationElementX : MonoBehaviour {

	private GameObject go;
	// Use this for initialization
	private Slider sl;

	void Start () {
		sl = GetComponent<Slider>();
		sl.onValueChanged.AddListener (delegate {ValueChangedCheck ();});
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ValueChangedCheck ()
	{
		if (go != null) {
			go.SendMessage("RotateX", sl.value);
		}
	}

	public void Activate (GameObject newGo)
	{	
		go = newGo;
	}

	public void SetValueSlider (float value)
	{
		this.sl.value = value;
	}

	void DisActivate ()
	{
		go = null;
	}
}
