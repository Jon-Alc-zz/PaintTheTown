using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_AudioRandomPitch : MonoBehaviour {

	private AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = gameObject.GetComponent<AudioSource> ();
		audio.pitch = (Random.value / 5) + .9f;
	}

}
