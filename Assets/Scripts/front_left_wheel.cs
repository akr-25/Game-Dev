using UnityEngine;

public class front_left_wheel : MonoBehaviour
{
	public Rigidbody rb;
	public float SideForce = 500f;

	// We marked this as "Fixed"Update because we
	// are using it to mess with physics.
	void FixedUpdate()
	{
		if (Input.GetKey("a"))
		{
			rb.AddForce(-SideForce * Time.deltaTime, 0, 0);   // Add a force of 2000 on the z-axis
		}
	}
}
