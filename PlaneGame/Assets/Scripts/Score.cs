using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int Coins;

    public Text CoinsText;

    public AudioSource ScoreCoin;


    public void AddOne()
    {
        Coins++;

        ScoreCoin.Play();

        CoinsText.text = Coins.ToString();
    }
}
