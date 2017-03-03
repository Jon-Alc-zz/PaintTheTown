using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_cubeMovement : MonoBehaviour {

	public float moveSpeed = 5f;
	public float rotateSpeed = 2.5f;

	private Rigidbody cubeRigidbody;

	// Use this for initialization
	void Start () {
		cubeRigidbody = gameObject.GetComponent<Rigidbody> ();
		cubeRigidbody.angularVelocity = new Vector3 (0f, rotateSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
