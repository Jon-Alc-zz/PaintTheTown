using UnityEngine;
using System.Collections;

public class scr_playerMovement : MonoBehaviour {

	public float speed = 1f; // movement speed
	public float fireRate; // Time between shots

	public GameObject playerShot; // player's shot to shoot
	public ParticleSystem playerMuzzlePSys; // muzzle of player's barrel
	public Transform shotSpawn; // where the bullet will be fired

	private float camRayLength = 100f;
	private float nextFire; // Time to next shot
	private Rigidbody playerRigidbody;
	private Vector3 movement;


	int floorMask;

	// Use this for initialization
	void Start () {
		floorMask = LayerMask.GetMask ("Floor");
		playerRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxisRaw ("Horizontal"); // get left/right
		float v = Input.GetAxisRaw ("Vertical");   // get up/down
		Move (h, v);
		Turning ();

		// Debug.Log (Time.time + " " + nextFire);

		// firing shots with 'Fire1'
		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			playerMuzzlePSys.Play();
			nextFire = Time.time + fireRate;
			Instantiate (playerShot, shotSpawn.position, shotSpawn.rotation);
		}

	}

	void Move (float h, float v) {
		// Set movement vector based on axis input
		movement.Set (h, 0f, v);
		// Normalize movement vector (No extra diagonal speed)
		// & make player movement tied to in-game second
		movement = movement.normalized * speed * Time.deltaTime; 
		// Move player to current position + movement
		playerRigidbody.MovePosition (transform.position + movement);

		playerRigidbody.position = new Vector3 (
			Mathf.Clamp(playerRigidbody.position.x, -9.5f, 9.5f),
			0.0f,
			Mathf.Clamp(playerRigidbody.position.z, -9.5f, 9.5f)
		);
	}

	void Turning () {
		// Create a ray from the mouse cursor on screen in the direction of the camera
		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		// Create a RaycastHit variable that stores info about what was hit
		RaycastHit floorHit;
		if (Physics.Raycast (camRay, out floorHit, camRayLength, floorMask)) {
			// Create a vector from the player to the point where the raycast from the mouse hit
			Vector3 playerToMouse = floorHit.point - transform.position;
			// Ensure vector is entirely on floor plane
			playerToMouse.y = 0f;
			// Create Quaternion based on looking down vector from player to mouse
			Quaternion newRotation = Quaternion.LookRotation (playerToMouse);
			// Set player's rotation to newRotation
			playerRigidbody.MoveRotation (newRotation);
		}
	}
}
