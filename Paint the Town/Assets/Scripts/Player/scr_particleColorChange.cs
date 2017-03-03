/* scr_particleColorChange.cs
 * Jonathan F. Alcantara
 * Changes color of particle system on gun muzzle to player's color
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_particleColorChange : MonoBehaviour {

	private ParticleSystem pSys;  // for this particle system
	private Renderer PlayerColor; // Renderer of player, for color

	void Start () {
		PlayerColor = GameObject.Find ("playerColor").GetComponent<Renderer> ();
		pSys = gameObject.GetComponent <ParticleSystem> ();

	}

	void Update () {
		// set color of particle system to player's color
		pSys.startColor = PlayerColor.material.color;
	}

}
