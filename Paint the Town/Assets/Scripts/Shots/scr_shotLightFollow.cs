/* scr_shotLightFollow.cs
 * Jonathan F. Alcantara
 * Sets light's position to follow parent object's position
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_shotLightFollow : MonoBehaviour {

	void Update () {
		transform.position = transform.parent.position; // follows parent Bullet's position
		// light is 3 layers down
		transform.position = new Vector3(transform.position.x, -3, transform.position.z);
	}
}
