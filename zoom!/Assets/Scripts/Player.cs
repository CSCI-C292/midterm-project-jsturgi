using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    [SerializeField] Camera cam;
    [SerializeField] roundEnd roundEnd; 
    float currentTilt = 0f;
    public float distanceTravelled;
    private Vector3 lastPosition;

    [SerializeField] TextMeshProUGUI distanceText;
    
    


    // Start is called before the first frame update
    void Start()
    {
        distanceTravelled = -6;
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.localEulerAngles = new Vector3(currentTilt, 0, 0);

        distanceTravelled += Vector3.Distance(transform.position,lastPosition);
        lastPosition = transform.position;
        distanceText.text = Mathf.Round(distanceTravelled).ToString();

        if (transform.position.y <= -2.26)
        {
            roundEnd.RoundEnd();
        }

        
        
    }

    
    
}
