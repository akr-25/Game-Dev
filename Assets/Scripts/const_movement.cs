using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class const_movement : MonoBehaviour
{
    public Rigidbody rb;
    public float zForce = 1000f;
    public float yForce = 0f;
    public float xForce = 0f;
    public float destroyTime = 20.0f;
    private float currentTime = 0f;

    void Start()
    {
        currentTime = 0f;
    }


    void FixedUpdate()
    {
        rb.AddForce(xForce * Time.deltaTime, yForce * Time.deltaTime, zForce * Time.deltaTime);
    }

    void Update()
    {
        Cardestroyer();
    }

    /// <summary>
    /// Description:
    /// Move the projectile in the direction it is heading
    /// Inputs: 
    /// none
    /// Returns: 
    /// void (no return)
    /// </summary>
    private void Cardestroyer()
    {
        currentTime += Time.deltaTime;
        // if the distance is greater than the destroyDistance
        if (currentTime>destroyTime)
        {
            Destroy(this.gameObject); // destroy the gameObject
            currentTime = 0f;
        }
    }
}
