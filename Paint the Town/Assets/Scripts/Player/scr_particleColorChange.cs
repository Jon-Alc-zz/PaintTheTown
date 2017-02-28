using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_particleColorChange : MonoBehaviour {

	private bool red = false;
	private bool green = false;
	private bool blue = false;
	private ParticleSystem pSys;

	// Use this for initialization
	void Start () {
		pSys = gameObject.GetComponent <ParticleSystem> ();

		red = false;
		green = false;
		blue = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) { // '1' is pressed
			if (red) red = false;
			else red = true;
		} 
		if (Input.GetKeyDown (KeyCode.Alpha2)) { // '2' is pressed
			if (green) green = false;
			else green = true;
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) { // '3' is pressed
			if (blue) blue = false;
			else blue = true;
		}

		// Debug.Log (red + " " + green + " " + blue);
		changeColor ();
	}

	void changeColor () {
		
		if (red && green && blue) { // RGB = White
			pSys.startColor = Color.white;
		} else if (red && green && !blue) { // RG = Yellow
			pSys.startColor = Color.yellow;
		} else if (red && !green && blue) { // RB = Violet
			pSys.startColor = Color.magenta;
		} else if (!red && green && blue) { // GB = Cyan
			pSys.startColor = Color.cyan;
		} else if (red && !green && !blue) { // Red
			pSys.startColor = Color.red;
		} else if (!red && green && !blue) { // Green
			pSys.startColor = Color.green;
		} else if (!red && !green && blue) { // Blue
			pSys.startColor = Color.blue;
		} else { // Black
			pSys.startColor = new Color(.15f, .15f, .15f, 1);
		}

	}

}
