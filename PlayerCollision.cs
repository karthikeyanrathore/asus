using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement movement;
	void OnCollisionEnter(Collision collisionInfo){


		if(collisionInfo.collider.name == "obstacle"){
			//Debug.Log("HIT");
			movement.enabled = false;
		}
	}
}
