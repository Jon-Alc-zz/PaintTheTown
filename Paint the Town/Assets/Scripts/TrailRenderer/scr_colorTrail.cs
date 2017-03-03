/* scr_colorTrail.cs
 * Jonathan F. Alcantara
 * Script that changes trailRenderer's starting color
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_colorTrail : MonoBehaviour {

	private TrailRenderer tRend;  // for this trail renderer
	private Renderer parentColor; // Renderer of player, for color

	void Start () {
		parentColor = gameObject.GetComponent<Renderer> ();
		tRend = gameObject.GetComponent <TrailRenderer> ();

	}

	void Update () {
		// set color of trail renderer to player's color
		tRend.startColor = parentColor.material.color;
	}

}
