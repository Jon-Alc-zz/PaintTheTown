using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_lightPulse : MonoBehaviour {

	public float minDistance = 2f;
	public float maxDistance = 2.5f;
	public float minIntensity = .5f;
	public float maxIntensity = 1.5f;
	public float speed = 1f;

	private Light light;
	private float lerpStart = 0.0f;
	private int sign = 1;

	// Use this for initialization
	void Start () {
		light = gameObject.GetComponent<Light> ();
	}

	// Update is called once per frame
	void Update () {
		lerpStart += speed * Time.deltaTime * sign;
		light.range = Mathf.Lerp (minDistance, maxDistance, lerpStart);
		light.intensity = Mathf.Lerp (maxIntensity, minIntensity, lerpStart);

		if (lerpStart > 1.0f || lerpStart < 0f) { sign *= -1; }
		// Debug.Log (lerpStart);
	}
}
