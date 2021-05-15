
using UnityEngine;

public class rear_wheel : MonoBehaviour
{

	public Rigidbody rb;
	public float ForwardForce = 500f;
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
	}
}