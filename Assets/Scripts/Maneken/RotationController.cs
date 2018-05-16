using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour {

	private GameObject sliderX;
	private GameObject sliderY;
	private GameObject sliderZ;
	private float oldAngleX;
	private float oldAngleY;
	private float oldAngleZ;
	private GameObject nodeGo;

	void OnMouseDown()
	{
		sliderX = GameObject.Find("SliderX");
		sliderY = GameObject.Find("SliderY");
		sliderZ = GameObject.Find("SliderZ");

		if (gameObject.CompareTag("Node")){
			nodeGo = this.gameObject;
			this.ActivateSliders();
			this.TranslateValueSlider ();
		} else {
			nodeGo = this.gameObject.transform.parent.gameObject;
			this.ActivateSliders();
			nodeGo.SendMessage("TranslateValueSlider");
		}

	}

	void RotateX (float value)
	{
		Debug.Log("value - " + value.ToString() +  "OldValue - " + oldAngleX);
		transform.Rotate( new Vector3(value - oldAngleX, 0, 0));
		oldAngleX = value;
	
	}

	void RotateY (float value)
	{
		transform.Rotate( new Vector3(0, value - oldAngleY, 0));
		oldAngleY = value;
	}

	void RotateZ (float value)
	{
		transform.Rotate( new Vector3(0, 0, value - oldAngleZ));
		oldAngleZ = value;
	}

	public void TranslateValueSlider ()
	{
		sliderX.SendMessage("SetValueSlider", this.oldAngleX);
		sliderY.SendMessage("SetValueSlider", this.oldAngleY);
		sliderZ.SendMessage("SetValueSlider", this.oldAngleZ);
	}

	protected void ActivateSliders ()
	{
		sliderX.SendMessage("Activate", nodeGo);
		sliderY.SendMessage("Activate", nodeGo);
		sliderZ.SendMessage("Activate", nodeGo);
	}
}
