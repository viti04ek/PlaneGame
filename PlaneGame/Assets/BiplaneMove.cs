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
    }
}
