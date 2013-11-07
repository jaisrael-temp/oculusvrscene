﻿using UnityEngine;
using System.Collections;

public class triggerPlane : MonoBehaviour {

	public int trigger;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider c) {
		var handler = (GameObject.Find("First Person Controller").GetComponent("triggerHandler") as triggerHandler);
		handler.handleTrigger(trigger);
	}
}