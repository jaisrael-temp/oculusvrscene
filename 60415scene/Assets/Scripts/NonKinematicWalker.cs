using UnityEngine;
using System.Collections;

public class NonKinematicWalker : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		rigidbody.AddForce(moveDirection);
	}
}
