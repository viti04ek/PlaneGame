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


        float x = Mathf.Clamp(transform.position.x, -147, 147);
        float y = transform.position.y;
        float z = transform.position.z;

        transform.position = new Vector3(x, y, z);
    }
}
