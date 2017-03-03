/* scr_lightColor.cs
 * Jonathan F. Alcantara
 * Sets light's color to parent object's color
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_lightColor : MonoBehaviour {

	private Light light;
	private Renderer objParent; // gets Renderer in parent object

	void Start () {
		light = gameObject.GetComponent<Light> ();	
	}

	void Update () {
		objParent = GetComponentInParent<Renderer> ();
		// set light's color to object parent's color
		light.color = objParent.material.color;
	}
}
