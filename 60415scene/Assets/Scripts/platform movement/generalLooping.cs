using UnityEngine;
using System.Collections;

public class generalLooping : MonoBehaviour {

	public Vector3[] displacements;
	public int[] timings;
	private Vector3 position;
	private int frame;
	private int index;

	// Use this for initialization
	void Start () {
		position = transform.position;
		frame = 0;
		index = 0;
	}
	
	void FixedUpdate () {
		int period = timings[index];


		float progress = ((float)frame%period)/((float)period);
		if (frame/period > 0) {
			frame -= period;
			position = position + displacements[index];
			index++;
			if (index == displacements.Length) index -= displacements.Length;
		}

		//simple linear interpolation
		Vector3 newPosition = ((1 - progress) * position) + (progress * (position + displacements[index]));

		transform.Translate(newPosition - transform.position);
		frame++;
	}
}
