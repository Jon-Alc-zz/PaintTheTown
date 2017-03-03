/* scr_lightPulse.cs
 * Jonathan F. Alcantara
 * Gives light a pulse effect, changing light.range and light.intensity
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_lightPulse : MonoBehaviour {

	public float minDistance = 2f;    // minimum distance of light.range
	public float maxDistance = 2.5f;  // maximum distance of light.range
	public float minIntensity = .5f;  // minimum intensity of light.intensity
	public float maxIntensity = 1.5f; // maximum intensity of light.intensity
	public float speed = 1f; 		  // speed of pulse for Lerp

	private Light light;
	private float lerpStart = 0.0f;
	private int sign = 1; // used to grow/shrink in Lerp

	void Start () {
		light = gameObject.GetComponent<Light> ();
	}

	void Update () {
		lerpStart += speed * Time.deltaTime * sign;
		// light.range = [minDistance, maxDistance]
		light.range = Mathf.Lerp (minDistance, maxDistance, lerpStart);
		// light.intensity = [maxIntensity, minIntensity], brighter when smaller
		light.intensity = Mathf.Lerp (maxIntensity, minIntensity, lerpStart);

		if (lerpStart > 1.0f || lerpStart < 0f) sign *= -1;
		// Debug.Log (lerpStart);
	}
}
