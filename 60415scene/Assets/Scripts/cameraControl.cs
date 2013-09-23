using UnityEngine;
using System.Collections;

public class cameraControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			var ball = GameObject.Find("test");
			if (ball != null) {
				Debug.Log("activated");
			}
		}
		var valueH = Input.GetAxis ("Horizontal");
		var valueV = Input.GetAxis ("Vertical");
		this.transform.Translate(0.1f*valueH,0.0f,0.1f*valueV);

	}
}
