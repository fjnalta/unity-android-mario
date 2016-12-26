using UnityEngine;
using System.Collections;

public class SimpleEnemy : MonoBehaviour {

	// Enemy Target
	public GameObject enemy;
	// Enemy Stats
	public float speed = 1.0f;
	public float gravity = 20.0f;

	// MovementVector
	private Vector3 moveDirection = Vector3.zero;
	// EnemyCharacterController
	CharacterController controller;

	void Start(){
		// Get EnemyCharacterController
		controller = GetComponent<CharacterController>();
		// Get Player as Enemy
		enemy = GameObject.FindGameObjectWithTag("Player");
	}

	void Update() {

		if (controller.isGrounded) {
			moveDirection = new Vector3 (-1, 0, 0);
			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= speed;
		}

		// Applay Gravity
		moveDirection.y -= gravity * Time.deltaTime;
		// Move Enemy in World
		controller.Move(moveDirection * Time.deltaTime);
	}

	void OnCollisionEnter(Collision col) {
		Debug.Log (col);
		doDamage (enemy);
		Destroy(this.gameObject);
	}

	void doDamage(GameObject target){
		target.GetComponent<PlayerController> ().takeDamage ();
	}
}
