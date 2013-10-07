using UnityEngine;
using System.Collections;

public class simpleRepeatedLinear : MonoBehaviour {

	public Vector3 displacement;
	public int period;
	private Vector3 position;
	private int frame;

	// Use this for initialization
	void Start () {
		position = transform.position;
		frame = 0;
	}
	
	// FixedUpdate is called once per physics update.
	void FixedUpdate () {
		float progress = ((float)frame%period)/((float)period);
		progress = (frame/period)%2 == 0 ? progress : 1.0f - progress;

		//simple linear interpolation
		Vector3 newPosition = ((1 - progress) * position) + (progress * (position + displacement));

		transform.Translate(newPosition - transform.position);
		frame++;
	}
}
