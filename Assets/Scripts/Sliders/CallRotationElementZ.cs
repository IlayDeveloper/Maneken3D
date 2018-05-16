using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallRotationElementZ : MonoBehaviour {

	private GameObject go;
	// Use this for initialization
	private Slider sl;
	private float oldValueSlider = 0;
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
			go.SendMessage("RotateZ", sl.value);
		}
	}

	void Activate (GameObject newGo)
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
