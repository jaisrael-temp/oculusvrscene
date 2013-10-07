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
		Debug.Log(transform.position);
		frame = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float progress = ((float)frame%period)/((float)period);
		progress = (frame/period)%2 == 0 ? progress : 1.0f - progress;

		Debug.Log(progress);

		//simple linear interpolation
		Vector3 newPosition = ((1 - progress) * position) + (progress * (position + displacement));

		Debug.Log(newPosition);
		Debug.Log(transform.position - newPosition);

		transform.Translate(newPosition - transform.position);
		frame++;
	}
}
