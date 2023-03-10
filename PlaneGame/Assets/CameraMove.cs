using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform Target;

    void Update()
    {
        if (Target)
            transform.position = Target.position;
    }
}
