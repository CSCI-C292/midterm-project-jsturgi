using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField] FlightPhysics physics;
    float thrustBoost = 250;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "ThrustBoost")
        {
            physics.thrust += thrustBoost;
            physics.inFlightBoost();
        }
    }

    
    
}
