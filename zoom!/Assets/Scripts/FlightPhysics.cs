using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightPhysics : MonoBehaviour
{
    public  Rigidbody2D rb;

    float lift = 600f;
    float flightPower = 1000f;// force that is applied on launch of player into sky
    float thrust = 0f; // force that is applied in flight, normally the result of powered flight, ie a jetpack or a bird's wings flapping
    float speed = 5f;
    float density = 30f;
    float airDensity = 1.25f;
    float surfaceAreaY = .25f;
    float surfaceAreaX = .47f;
    public bool inFlight = false;
    float launchAngle = 45f;
    float gravityAcceleration = 9.81f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Launch") && !inFlight)
        {
            Liftoff();
        }
    }

    void Liftoff()
    {
        inFlight = true;
        
        rb.AddForce((Vector2.up) * lift);
        rb.AddForce(Vector2.right * flightPower );
        
    }

    void FlightPath()
    {
        
    }

    // for the following formulas/functions, i used this stack overflow page to find the formulas for lift, lift coefficient, and drag https://stackoverflow.com/questions/49716989/unity-aircraft-physics

}
