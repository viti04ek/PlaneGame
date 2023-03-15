using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biplane : MonoBehaviour
{
    private int Health = 5;

    public Score Score;


    private void OnTriggerEnter(Collider other)
    {
        Bomb bomb = other.gameObject.GetComponent<Bomb>();

        if (bomb)
        {
            Health -= 1;

            if(Health <= 0)
            {
                Destroy(gameObject);
            }

            bomb.Die();
        }


        Coin coin = other.gameObject.GetComponent<Coin>();

        if (coin)
        {
            coin.Die();

            Score.AddOne();
        }
    }
}
