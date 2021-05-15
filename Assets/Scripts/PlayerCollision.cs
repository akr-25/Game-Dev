using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerCollision : MonoBehaviour 
{

	public Movement movement;     // A reference to our PlayerMovement script
	public int life = 3;
	// This function runs when we hit another object.
	// We get information about the collision and call it "collisionInfo".
	void OnCollisionEnter (Collision collisionInfo)
	{
		// We check if the object we collided with has a tag called "Obstacle".
		if (collisionInfo.collider.tag == "Obstacle" || collisionInfo.collider.tag == "Car")
		{
			life--;
			if (life == 0)
			{
				movement.enabled = false;   // Disable the players movement.
				FindObjectOfType<GameManager>().EndGame();
			}
		}
		if (collisionInfo.collider.name == "End Wall")
        {
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().EndGame();
		}
	}

}
