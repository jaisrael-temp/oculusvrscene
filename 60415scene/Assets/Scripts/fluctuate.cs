using UnityEngine;
using System.Collections;

public class fluctuate : MonoBehaviour {

	private int frame = 0;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		frame++;
		if (frame > 100) {
			var emitter = (gameObject.GetComponents(typeof(ParticleEmitter))[0] as ParticleEmitter);
			var c = emitter.particles;
			for(int i = 0; i < c.Length; i++) {
				c[i].position += new Vector3(0.0f, 0.1f, 0.0f);
				if(i == 0) {
					Debug.Log(c[i].position);
					Debug.Log(frame);
				}
			}
			emitter.particles = c;

		}
	}
}
