using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmovement : MonoBehaviour
{
    //referencing to the Rigidbody component 
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideForce = 500f;

    //Using FixedUpdate since physics is used
    void FixedUpdate()
    {
        //Adding forward force to the car 
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }
    }
}
