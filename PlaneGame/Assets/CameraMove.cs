using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform Target;

    void Update()
    {
        Vector3 change = new Vector3(Target.position.x, 0, 0);

        if (Target)
            transform.position = change;


        if (transform.position.x > 147)
            transform.position = new Vector3(147, transform.position.y, transform.position.z);

        if (transform.position.x < -147)
            transform.position = new Vector3(-147, transform.position.y, transform.position.z);
    }
}
