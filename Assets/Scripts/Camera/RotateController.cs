using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour {

	public int rotateSpeed = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void RotateX ()
	{
		 transform.RotateAround(Vector3.zero, Vector3.right, rotateSpeed * Time.deltaTime);
	}

	void RotateY ()
	{
		 transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);
	}
}
