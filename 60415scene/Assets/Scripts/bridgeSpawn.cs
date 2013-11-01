using UnityEngine;
using System.Collections;

public class bridgeSpawn : MonoBehaviour {

	public Vector3 start;
	public Vector3 end;
	//public float sag;
	public int spawnAmount;

	//private float maxProgress;


	// Use this for initialization
	void Start () {
		for(int x = 0; x < spawnAmount; x++) {
			GameObject currentPlank = new GameObject();
			currentPlank.AddComponent ("BoxCollider");
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = GameObject.Find("First Person Controller").transform.position;

	}
}
