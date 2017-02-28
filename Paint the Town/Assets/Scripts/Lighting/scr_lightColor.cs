using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_lightColor : MonoBehaviour {

	private Light light;
	private Renderer objParent;

	// Use this for initialization
	void Start () {
		light = gameObject.GetComponent<Light> ();	
	}
	
	// Update is called once per frame
	void Update () {
		objParent = GetComponentInParent<Renderer> ();
		light.color = objParent.material.color;
	}
}
