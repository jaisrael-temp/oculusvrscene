using UnityEngine;
using System.Collections;

public class death : MonoBehaviour {

	public Vector3 spawnpos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter( Collider other) {
		Debug.Log(other.gameObject.name);
		if (other.gameObject.name == "First Person Controller") {
			other.gameObject.transform.Translate(spawnpos - other.gameObject.transform.position);
			Debug.Log(other.gameObject.transform.position);
		}
	}
}
