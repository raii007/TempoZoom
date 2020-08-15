using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    //referencing to the Rigidbody component 
    public Rigidbody rb;

    public float forwardForce = 2000f;

    //Using FixedUpdate since physics is used
    void FixedUpdate()
    {
        //Adding forward force to the car 
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }
}
