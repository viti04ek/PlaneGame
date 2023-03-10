using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiplaneMove : MonoBehaviour
{
    public Rigidbody Rigidbody;

    public float ConstantForceValue;
    public float ForceVelue;
    public float TorqueValue;

    void FixedUpdate()
    {
        Rigidbody.AddForce(transform.forward * ConstantForceValue, ForceMode.VelocityChange);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            Rigidbody.AddForce(transform.forward * ForceVelue, ForceMode.VelocityChange);

        float horizontalInput = Input.GetAxis("Horizontal");
        Rigidbody.AddTorque(transform.right * TorqueValue * horizontalInput, ForceMode.VelocityChange);


        if (transform.position.y > 23)
            transform.position = new Vector3(transform.position.x, 23, transform.position.z);

        if (transform.position.y < -27)
            transform.position = new Vector3(transform.position.x, -27, transform.position.z);

        if (transform.position.x > 200)
            transform.position = new Vector3(200, transform.position.y, transform.position.z);

        if (transform.position.x < -200)
            transform.position = new Vector3(-200, transform.position.y, transform.position.z);
    }
}
