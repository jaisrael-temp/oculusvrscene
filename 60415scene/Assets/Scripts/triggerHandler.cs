using UnityEngine;
using System.Collections;

public class triggerHandler : MonoBehaviour {

	public enum Triggers {firstGap}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void handleTrigger (Triggers t) {

		switch (t) {
			case Triggers.firstGap:
				var platform = GameObject.Find("gap_platform_1");
				platform.renderer.enabled = true;
				Debug.Log(platform);
				break;
			default:
				break;
		}
	}
}
