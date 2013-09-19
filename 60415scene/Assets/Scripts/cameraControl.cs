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
				var anim = ball.animator;
				if (anim != null) {
					Debug.Log("accessed");
				}
			}
		}
	}
}
