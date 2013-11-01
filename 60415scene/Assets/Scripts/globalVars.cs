using UnityEngine;
using System.Collections;

public class globalVars : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Debug.Log("quitting");
			Application.Quit();
		}
	}
}
