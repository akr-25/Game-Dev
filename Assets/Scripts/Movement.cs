using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public Rigidbody rb;
	public float ForwardForce = 1000f;
	public float SideForce = 500f;

	// We marked this as "Fixed"Update because we
	// are using it to mess with physics.
	void FixedUpdate()
	{
		if (Input.GetKey("w"))
		{
			rb.AddForce(0, 0, -ForwardForce * Time.deltaTime);   // Add a force of 2000 on the z-axis
		}
		if (Input.GetKey("s"))
        {
			rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
			rb.AddForce(SideForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
			rb.AddForce(-SideForce * Time.deltaTime, 0, 0);
        }
        if (rb.position.z > 1010f)
        {
			FindObjectOfType<GameManager>().EndGame();
        }
	}
}
