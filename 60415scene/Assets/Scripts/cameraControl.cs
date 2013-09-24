using UnityEngine;
using System.Collections;

public class cameraControl : MonoBehaviour {

	// Use this for initialization
	Vector3 previousMousePos;
	void Start () {
		previousMousePos = Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			var ball = GameObject.Find("test");
			if (ball != null) {
				Debug.Log("activated");
			}
		}

		//var maxVelocity = 0.5f;
		//var acceleration = 0.1f;


		var valueH = Input.GetAxis ("Horizontal");
		var valueV = Input.GetAxis ("Vertical");
		this.transform.Translate (0.5f*valueH, 0.0f, 0.5f*valueV);

		var mousePos = Input.mousePosition;
		var mouseDelta = Input.mousePosition - previousMousePos;
		previousMousePos = mousePos;
		this.transform.Rotate (mouseDelta.y*0.1f, -mouseDelta.x*0.1f, 0.0f - this.transform.rotation.z);
		//Debug.Log(this.transform.up);
	}
}
