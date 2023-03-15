using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiplaneMove : MonoBehaviour
{
    public Rigidbody Rigidbody;

    public float ConstantForceValue;
    public float ForceVelue;
    public float TorqueValue;

    private bool _move = true;


    private void Update()
    {
        float x = Mathf.Clamp(transform.position.x, -200, 200);
        float y = Mathf.Clamp(transform.position.y, -27, 23);
        float z = transform.position.z;

        transform.position = new Vector3(x, y, z);
    }


    void FixedUpdate()
    {
        if (_move)
        {
            Rigidbody.AddForce(transform.forward * ConstantForceValue, ForceMode.VelocityChange);

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                Rigidbody.AddForce(transform.forward * ForceVelue, ForceMode.VelocityChange);

            float horizontalInput = Input.GetAxis("Horizontal");
            Rigidbody.AddTorque(transform.right * TorqueValue * horizontalInput, ForceMode.VelocityChange);
        }
    }


    public void SetMove(bool newValue)
    {
        _move = newValue;
    }
}
