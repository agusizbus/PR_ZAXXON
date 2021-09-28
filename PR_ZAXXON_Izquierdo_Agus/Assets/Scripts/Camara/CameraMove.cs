using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField] Transform playerPosition;
    [SerializeField] float smoothVelocity = 0.3F;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;
    [SerializeField] Transform cameraHeight;

    void Update()
    {

        //Con este código, la cámara seguirá al jugador, pero alejado algo en el eje Z

        transform.position = new Vector3(playerPosition.position.x, cameraHeight.position.y + 1 , playerPosition.position.z - 5);


        Vector3 targetPosition = playerPosition.TransformPoint (new Vector3(0, 5, -10));

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);

        transform.LookAt(cameraHeight);

      
    }

 }
