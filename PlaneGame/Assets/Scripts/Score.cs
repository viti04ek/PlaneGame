using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int Coins;

    public Text CoinsText;

    public AudioSource ScoreCoin;

    public Creator Creator;


    public void AddOne(GameObject scoreCoin)
    {
        Coins++;

        ScoreCoin.Play();

        CoinsText.text = Coins.ToString();

        Creator.RemoveCoin(scoreCoin);
    }


    public void Restart()
    {
        Coins = 0;
        CoinsText.text = Coins.ToString();
    }
}
