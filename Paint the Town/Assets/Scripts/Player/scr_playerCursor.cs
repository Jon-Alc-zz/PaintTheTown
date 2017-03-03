/* scr_playerCursor.cs
 * Jonathan F. Alcantara
 * Attaches cursor to player mouse
 */

using UnityEngine;
using System.Collections;

public class scr_playerCursor : MonoBehaviour {
	
	void Update () {
		Vector3 temp = Input.mousePosition; // temp gets position of mouse
		temp.z = 5f; // cursor must be on highest layer for player to see
		// point to orthographic camera
		transform.position = Camera.main.ScreenToWorldPoint (temp);
	}

}
