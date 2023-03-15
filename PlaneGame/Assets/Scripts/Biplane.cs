using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biplane : MonoBehaviour
{
    public int Health { get; private set; } = 5;

    public Score Score;

    public Restart RestartGame;

    public HealthBar HealthBar;

    private Quaternion _startRotation;


    private void Start()
    {
        _startRotation = transform.rotation;
    }


    private void OnTriggerEnter(Collider other)
    {
        Bomb bomb = other.gameObject.GetComponent<Bomb>();

        if (bomb)
        {
            Health -= 1;
            HealthBar.HideHeart();

            if (Health <= 0)
            {
                RestartGame.GameOver();
            }

            bomb.Die();
        }


        Coin coin = other.gameObject.GetComponent<Coin>();

        if (coin)
        {
            coin.Die();

            Score.AddOne(other.gameObject);
        }
    }


    public void Restart()
    {
        transform.position = new Vector3(-5f, 2f, 0f);
        transform.rotation = _startRotation;

        Health = 5;
    }
}
