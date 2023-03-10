using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    public GameObject CoinPrefab;
    public GameObject BombPrefab;

    void Start()
    {
        for (int i = -200; i < 200; i++)
        {
            if (Random.Range(0, 6) == 0)
            {
                Vector3 position = new Vector3(i, Random.Range(-25f, 25f), 0);

                if (Random.Range(0, 3) == 0)
                    Instantiate(BombPrefab, position, Quaternion.identity);
                else
                    Instantiate(CoinPrefab, position, Quaternion.identity);
            }
        }
    }
}
