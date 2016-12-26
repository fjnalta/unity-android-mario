using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float speed = 1.0f;
	public float jumpSpeed = 10f;
	public float gravity = 20.0f;

	// MovementVector
	private Vector3 moveDirection = Vector3.zero;

	// CharacterController
	CharacterController controller;

	void Start(){
		// Get CharacterController
		controller = GetComponent<CharacterController>();	
	}

	void Update() {

		if (controller.isGrounded) {
			moveDirection = new Vector3(1, 0, 0);
			moveDirection = transform.TransformDirection(moveDirection);

			if (Input.GetButton ("Run")) {
				moveDirection *= speed * 2;
				jumpSpeed = 12f;
			} else {
				moveDirection *= speed;
				jumpSpeed = 10f;
			}

			if (Input.GetButton ("Jump")) {
				moveDirection.y = jumpSpeed;
			}
		}

		// Applay Gravity
		moveDirection.y -= gravity * Time.deltaTime;

		// Move Character in World
		controller.Move(moveDirection * Time.deltaTime);
	}
}