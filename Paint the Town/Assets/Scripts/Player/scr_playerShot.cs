using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerShot : MonoBehaviour {

	public float speed;

	private Renderer bulletRenderer;
	private Renderer PlayerColor;
	private Rigidbody shotRigidbody;

	// Use this for initialization
	void Start () {
		PlayerColor = GameObject.Find ("playerColor").GetComponent<Renderer> (); 
		bulletRenderer = gameObject.GetComponent<Renderer> ();
		bulletRenderer.material.color = PlayerColor.material.color;
		shotRigidbody = GetComponent<Rigidbody> ();
		shotRigidbody.velocity = transform.up * speed;
	}

}
