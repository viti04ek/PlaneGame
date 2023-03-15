using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public void Update()
    {
        transform.Rotate(0, 150 * Time.deltaTime, 0);
    }


    public void Die()
    {
        Destroy(gameObject);
    }
}
