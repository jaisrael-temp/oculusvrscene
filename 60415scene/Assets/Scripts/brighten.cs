using UnityEngine;
using System.Collections;

public class brighten : MonoBehaviour {

	public bool shouldFade;
	public int fadeTime;
	private int frame;

	// Use this for initialization
	void Start () {
		frame = 0;
		gameObject.renderer.material.SetFloat("_Darkness", 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		if (shouldFade) {
			frame++;
			float darkness = (float)frame/(float)fadeTime * 0.5f + 0.5f;
			if (darkness > 1.0f) {
				darkness = 1.0f;
				shouldFade = false;
			}
			gameObject.renderer.material.SetFloat("_Darkness", darkness);
		}
	}
}
