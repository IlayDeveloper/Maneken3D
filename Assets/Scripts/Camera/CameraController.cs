using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private bool startToClose = false;
	private bool startToFar = false;
	public float speed = 10;

	public Transform target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.LookAt(this.target);

		if (this.startToFar == true){
			this.ToFar();
		}
		if (this.startToClose == true){
			this.Toclose();
		}
	}

	void Toclose ()
	{
		Debug.Log("end");
		transform.position.Normalize();
		transform.Translate( transform.position.normalized * this.speed);
	}

	void ToFar ()
	{
		transform.Translate((-1) * transform.position.normalized * this.speed);
	}

	void StartUpToClose ()
	{
		Debug.Log("start");
		this.startToClose = true;
	}

	void EndToClose ()
	{
		Debug.Log("end");
		this.startToClose = false;
	}

		void StartUpToFar ()
	{
		this.startToFar = true;
	}

	void EndToFar ()
	{
		this.startToFar = false;
	}
}
