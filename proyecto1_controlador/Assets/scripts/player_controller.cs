using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    //velocidad movimiento
    private float speed = 40;
    //velocidad rotacion
    private float turnSpeed = 40;

    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //MOVIMIENTO HACIA ADELANTE
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // movimiento lateral
        transform.Rotate(Vector3.up, angle: turnSpeed * Time.deltaTime * horizontalInput);
    }
}
