using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public List<Image> Hearts = new List<Image>();

    public Biplane Biplane;


    public void HideHeart()
    {
        Hearts[Biplane.Health].enabled = false;
    }


    public void Restart()
    {
        for (int i = 0; i < Hearts.Count; i++)
        {
            Hearts[i].enabled = true;
        }
    }
}
