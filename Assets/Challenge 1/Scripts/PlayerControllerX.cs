using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    float speed = 0.5f;
    float rotationSpeed = 75;
    float verticalInput;

    // Update is called once per frame
    void FixedUpdate()
    {

        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);



        // transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
