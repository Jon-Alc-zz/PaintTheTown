using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_playerAudioHumIdle : MonoBehaviour {

	public AudioClip hummer_loop;

	private AudioSource hummerIdle;

	// Use this for initialization
	IEnumerator	Start () {
		hummerIdle = gameObject.GetComponent<AudioSource> ();

		hummerIdle.Play ();
		yield return new WaitForSeconds (hummerIdle.clip.length);
		hummerIdle.clip = hummer_loop;
		hummerIdle.loop = true;
		hummerIdle.Play ();
	}

}
