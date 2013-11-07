using UnityEngine;
using System.Collections;

public class triggerHandler : MonoBehaviour {

	public enum Triggers {firstGap, largeMove}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void handleTrigger (int t) {

		switch ((Triggers)t) {
			case Triggers.firstGap:
				var platform = GameObject.Find("gap_platform_1");
				platform.renderer.enabled = true;
				Debug.Log(platform);
				break;
			case Triggers.largeMove:
				var platform2 = GameObject.Find("large_move_platform");
				(platform2.GetComponent("generalLooping") as generalLooping).movementEnabled = true;
				break;
			default:
				break;
		}
	}
}
