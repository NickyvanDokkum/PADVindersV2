using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneyValue : MonoBehaviour
{
    private int money;
    [SerializeField] private Text text;

    public void SetStat(int stat)
    {
        money = stat;
        text.text = "Money: " + money;
    }


    public void AddValue(int stat)
    {
        money += stat;
        text.text = "Money: " + money;
    }
}
