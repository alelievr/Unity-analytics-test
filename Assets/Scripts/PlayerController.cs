using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float movePower = 10;
	public float maxVelocity = 10;

	new Rigidbody2D	rigidbody;
	Vector2 move;

	new Camera camera;

	void Start ()
	{
		rigidbody = GetComponent< Rigidbody2D >();
		camera = Camera.main;
	}
	
	void Update ()
	{
		move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
	}

	void LateUpdate()
	{
		Vector3 camPos = camera.transform.position;

		camPos.x = transform.position.x;
		camPos.y = transform.position.y;

		camera.transform.position = camPos;
	}

	void FixedUpdate()
	{
		rigidbody.AddForce(move * movePower, ForceMode2D.Force);
		rigidbody.velocity = Vector2.ClampMagnitude(rigidbody.velocity, maxVelocity);
	}
}
