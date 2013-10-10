using UnityEngine;
using System.Collections;

public class enablePlatform : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter( Collider other) {
		
		foreach (var plat in GameObject.FindGameObjectsWithTag("platform")) {
			var p = plat.GetComponent("simpleRepeatedLinear") ?? plat.GetComponent("generalLooping");
			(p as platform).movementEnabled = true;
		}
	}
}
