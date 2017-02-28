using UnityEngine;
using System.Collections;

public class scr_playerCursor : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = Input.mousePosition;
		temp.z = 5f;
		transform.position = Camera.main.ScreenToWorldPoint (temp);
	}

}
