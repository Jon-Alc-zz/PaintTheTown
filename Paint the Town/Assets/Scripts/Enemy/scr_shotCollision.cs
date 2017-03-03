using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_shotCollision : MonoBehaviour {

	public GameObject ps_enemyDeath;

	private Renderer thisRenderer;
	private Renderer pShotRenderer;
	private ParticleSystem deathPS;

	void Start(){
		thisRenderer = gameObject.GetComponent<Renderer> ();
 
	}
	void OnTriggerEnter(Collider other) {
		if (other.tag == "PlayerShot") {
			pShotRenderer = other.GetComponentInParent<Renderer> ();
			if (pShotRenderer.material.color == thisRenderer.material.color) {
				var tester = Instantiate (ps_enemyDeath, transform.position, transform.rotation);
				deathPS = tester.GetComponent<ParticleSystem> ();
				deathPS.startColor = thisRenderer.material.color;
				Destroy (gameObject);
			}
			Destroy (other.gameObject);
		}

		if (other.tag == "Player") {
			Destroy (gameObject);
			Destroy (other.gameObject);
		}
	}

}
