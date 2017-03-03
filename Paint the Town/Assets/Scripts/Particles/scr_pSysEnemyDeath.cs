using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_pSysEnemyDeath : MonoBehaviour {

	private bool created = false;
	private float timer = 0f;

	private AudioSource audio;
	private ParticleSystem pSys;
	private Renderer playerBullet;

	void Start () {
		pSys = gameObject.GetComponent<ParticleSystem>();
		audio = gameObject.GetComponent<AudioSource>();
		pSys.Play ();
		audio.Play ();
	}

	void Update () {
		timer += Time.deltaTime;
		Debug.Log (timer);
		if (timer >= 1f) Destroy (gameObject);
	}
}
