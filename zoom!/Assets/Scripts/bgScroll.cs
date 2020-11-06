using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgScroll : MonoBehaviour
{
    private float length;
    private float startPosition;

    private Transform cameraTransform;

    [SerializeField] private Vector2 parralaxEffect;
    private Vector3 lastCameraPosition;
    // Start is called before the first frame update
    void Start()
    {
      cameraTransform = Camera.main.transform;
      lastCameraPosition = cameraTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
       Vector3 deltaMovement = new Vector3(cameraTransform.position.x - lastCameraPosition.x, cameraTransform.position.y - lastCameraPosition.y, 0);
       transform.position += new Vector3(deltaMovement.x*parralaxEffect.x, deltaMovement.y * parralaxEffect.y, 0);
       lastCameraPosition = cameraTransform.position;
      
    }
}
