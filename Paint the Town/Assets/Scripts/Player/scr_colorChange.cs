/* scr_colorChange.cs
 * Jonathan F. Alcantara
 * Gives player ability to change color of main object
 */

using UnityEngine;
using System.Collections;

public class scr_colorChange : MonoBehaviour {

	private bool red = false;   // status of red color
	private bool green = false; // status of green color
	private bool blue = false;  // status of blue color
	private Renderer objColor;  // Renderer of this object

	void Start () {
		objColor = gameObject.GetComponent <Renderer> ();
		objColor.enabled = true;
		red = false;
		green = false;
		blue = false;
	}

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

		/* // Didn't realize colors had default values
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
			objColor.material.color = new Color(.1f, .1f, .1f, 1f); // Color.black is too dark
		}
		*/

		// Messy but generally more efficient, always 3-4 conditional checks
		if (red) {
			if (green) {
				if (blue) objColor.material.color = Color.white;
				else objColor.material.color = Color.yellow;
			} else if (blue) objColor.material.color = Color.magenta;
			else objColor.material.color = Color.red;
		} else if (green) {
			if (blue) objColor.material.color = Color.cyan;
			else objColor.material.color = Color.green;
		} else if (blue) objColor.material.color = Color.blue;
		else objColor.material.color = new Color (.1f, .1f, .1f, 1f); // Color.black is too dark

	}
		
}
