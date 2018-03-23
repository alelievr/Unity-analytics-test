using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
	public float		attractionPower = 2;

	public CircleCollider2D	attractionCollider;

	void Start ()
	{
	}
	
	void OnTriggerStay2D(Collider2D other)
	{
		Vector2 dir = (other.transform.position - transform.position).normalized;
		float p = 1f - (dir.magnitude / attractionCollider.radius);
		other.GetComponent< Rigidbody2D >().AddForce(-dir * attractionPower * p, ForceMode2D.Force);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		GameManager.instance.Lose();
	}
}
