using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    private int ammoCount = 3;
    //[SerializeField] GameObject player;
    [SerializeField] FlightPhysics player;
    float engineBoost = 3000f;
    float liftBoost = 5000f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Launch") && ammoCount > 0 && player.inFlight)
        {
            Debug.Log("Shot");
            ammoCount--;
            Shoot();
        }
    }
/*
    public void OnMouseOver()
    {
        Debug.Log("Body Entered");
        if (Input.GetButtonDown("Launch") && ammoCount > 0 && player.inFlight)
        {
            Debug.Log("Shot");
            ammoCount--;
            Shoot();
        }
    }
    */
    private void Shoot()
    {
        player.rb.AddForce(Vector2.up * liftBoost);
        player.rb.AddForce(Vector2.right * engineBoost);

    }
/*
    public void OnMouseDown()
    {
        Debug.Log("Body Entered");
        if (Input.GetButtonDown("Launch") && ammoCount > 0 && player.inFlight)
        {
            Debug.Log("Shot");
            ammoCount--;
            Shoot();
        }
    }
*/


}
