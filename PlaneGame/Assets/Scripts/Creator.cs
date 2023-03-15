using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    public GameObject CoinPrefab;
    public GameObject BombPrefab;

    public List<GameObject> Coins = new List<GameObject>();
    public List<GameObject> Bombs = new List<GameObject>();

    public Restart RestartGame;


    private void Start()
    {
        Restart();
    }


    public void Restart()
    {
        DestroyOldObjects();


        for (int i = -200; i < 200; i++)
        {
            if (Random.Range(0, 6) == 0)
            {
                Vector3 position = new Vector3(i, Random.Range(-25f, 23f), 0);

                if (Random.Range(0, 3) == 0)
                {
                    GameObject newBomb = Instantiate(BombPrefab, position, Quaternion.identity);
                    Bombs.Add(newBomb);
                }
                else
                {
                    GameObject newCoin = Instantiate(CoinPrefab, position, Quaternion.identity);
                    Coins.Add(newCoin);
                }
            }
        }
    }


    private void DestroyOldObjects()
    {
        for (int i = 0; i < Coins.Count; i++)
            Destroy(Coins[i]);

        Coins.Clear();


        for (int i = 0; i < Bombs.Count; i++)
            Destroy(Bombs[i]);

        Bombs.Clear();
    }


    public void RemoveCoin(GameObject coin)
    {
        Coins.Remove(coin);

        if (Coins.Count == 0)
            RestartGame.GameOver();
    }
}
