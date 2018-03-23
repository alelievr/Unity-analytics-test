using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D other)
	{
		GameManager.instance.Win();
	}
}
