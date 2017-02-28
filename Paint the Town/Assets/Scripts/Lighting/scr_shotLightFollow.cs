using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_shotLightFollow : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.parent.position;
		transform.position = new Vector3(transform.position.x, -3, transform.position.z);
	}
}
