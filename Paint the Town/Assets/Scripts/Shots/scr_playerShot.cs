/* scr_shotLightFollow.cs
 * Jonathan F. Alcantara
 * Script for bullet characteristics
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerShot : MonoBehaviour {

	public float speed = 12.5f; 	 // speed of bullet

	private Renderer bulletRenderer; // Renderer for bullet, for color
	private Renderer PlayerColor; 	 // Renderer of player, for color
	private Rigidbody shotRigidbody;

	// Use this for initialization
	void Start () {
		// find existing instance of playerColor object and get its renderer
		PlayerColor = GameObject.Find ("playerColor").GetComponent<Renderer> ();
		// set color of bullet to player's color
		bulletRenderer = gameObject.GetComponent<Renderer> ();
		bulletRenderer.material.color = PlayerColor.material.color;
		shotRigidbody = GetComponent<Rigidbody> ();
		shotRigidbody.velocity = transform.up * speed; // move bullet
	}

}
