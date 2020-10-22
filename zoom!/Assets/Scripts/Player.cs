using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] Camera cam;
    float currentTilt = 0f;
    
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.localEulerAngles = new Vector3(currentTilt, 0, 0);

        
        
    }

    
    
}
