using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 1000;
    public float lateralForce = 500;

    // Start is called before the first frame update
    void Start()
    {
        // Reference to Rigidbody component called 'rb'
        rb.AddForce(0, 200, 500);
    }

    // 'FixedUpdate' because we are interacting with physics
    void FixedUpdate()
    {   
        // Time.deltaTime is the time between individual frames on a user's system. Therefore, we scale our 
        // force by Time.deltaTime, so that the rate of force increase with time is equal for all users
        rb.AddForce(0,0, forwardForce * Time.deltaTime); // Add constant force on z-axis

        if (Input.GetKey("d"))
        {
            rb.AddForce(lateralForce *Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-lateralForce * Time.deltaTime, 0 ,0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
