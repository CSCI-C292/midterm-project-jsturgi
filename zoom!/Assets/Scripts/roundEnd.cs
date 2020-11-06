using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roundEnd : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private FlightPhysics physics;

    public int playerMoney=0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RoundEnd()
    {
        physics.enabled = false;
        playerMoney += (int) Mathf.Round(player.distanceTravelled/10);
    }
}
