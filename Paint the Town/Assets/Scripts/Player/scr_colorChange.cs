using UnityEngine;
using System.Collections;

public class scr_colorChange : MonoBehaviour {

	private bool red = false;
	private bool green = false;
	private bool blue = false;
	private Renderer objColor;

	// Use this for initialization
	void Start () {
		objColor = gameObject.GetComponent <Renderer> ();
		objColor.enabled = true;
		red = false;
		green = false;
		blue = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			if (red) red = false;
			else red = true;
		} 
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			if (green) green = false;
			else green = true;
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			if (blue) blue = false;
			else blue = true;
		}

		// Debug.Log (red + " " + green + " " + blue);
		changeColor ();
	}

	void changeColor () {

		/* // If using Materials
		if (colors.Length == 0)
			return;
		
		int index = 0;

		if (red && green && blue) { // RGB = White
			index = 0;
		} else if (red && green && !blue) { // RG = Yellow
			index = 1;
		} else if (red && !green && blue) { // RB = Violet
			index = 2;
		} else if (!red && green && blue) { // GB = Cyan
			index = 3;
		} else if (red && !green && !blue) { // Red
			index = 4;
		} else if (!red && green && !blue) { // Green
			index = 5;
		} else if (!red && !green && blue) { // Blue
			index = 6;
		} else { // Black
			index = 7;
		}

		objColor.sharedMaterial = colors [index];
		*/

		if (red && green && blue) { // RGB = White
			objColor.material.color = Color.white;
		} else if (red && green && !blue) { // RG = Yellow
			objColor.material.color = Color.yellow;
		} else if (red && !green && blue) { // RB = Violet
			objColor.material.color = Color.magenta;
		} else if (!red && green && blue) { // GB = Cyan
			objColor.material.color = Color.cyan;
		} else if (red && !green && !blue) { // Red
			objColor.material.color = Color.red;
		} else if (!red && green && !blue) { // Green
			objColor.material.color = Color.green;
		} else if (!red && !green && blue) { // Blue
			objColor.material.color = Color.blue;
		} else { // Black
			objColor.material.color = new Color(.1f, .1f, .1f, 1f);
		}
			
	}
		
}
