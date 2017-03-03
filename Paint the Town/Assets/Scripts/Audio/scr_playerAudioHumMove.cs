using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerAudioHumMove : MonoBehaviour {

	private AudioSource hummerMove;
	private scr_playerMovement moveScript;

	// Use this for initialization
	void Start () {
		hummerMove = gameObject.GetComponent<AudioSource> ();
		moveScript = gameObject.GetComponent<scr_playerMovement> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (moveScript.isMoving) {
			if (!hummerMove.isPlaying) hummerMove.Play ();
		} else hummerMove.Pause ();
	}
}
