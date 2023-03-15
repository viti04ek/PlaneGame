using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public GameObject RestartObject;

    public Text ResultText;

    public Biplane Biplane;
    public BiplaneMove BiplaneMove;
    public Creator Creator;
    public Score Score;
    public HealthBar HealthBar;


    public void GameOver()
    {
        BiplaneMove.SetMove(false);
        RestartObject.SetActive(true);

        ResultText.text = $"You scored {Score.Coins} coins";
    }


    public void RestartGame()
    {
        RestartObject.SetActive(false);
        BiplaneMove.SetMove(true);

        Creator.Restart();
        Biplane.Restart();
        Score.Restart();
        HealthBar.Restart();
    }
}
