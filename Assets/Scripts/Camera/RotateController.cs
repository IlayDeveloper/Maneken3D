using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour {

	public int rotateSpeed = 100;
	// Use this for initialization
	private bool rotateX = false;
	private bool rotateY = false;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.rotateX == true){
			this.RotateX();
		}
		if (this.rotateY == true){
			this.RotateY();
		}
	}

	void RotateX ()
	{
		 transform.RotateAround(Vector3.zero, Vector3.right, rotateSpeed * Time.deltaTime);
	}

	void RotateY ()
	{
		 transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);
	}

	void StartRotateX ()
	{
		this.rotateX = true;
	}

	void StartRotateY ()
	{
		this.rotateY = true;
	}

	void EndRotateY ()
	{
		this.rotateY = false;
	}
		void EndRotateX ()
	{
		this.rotateX = false;
	}
}
