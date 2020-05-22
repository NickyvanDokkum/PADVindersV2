using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work : Activities
{
    [SerializeField] moneyValue statMoney;

    public override void ChangeStats(int amount)
    {
        statMoney.AddValue(amount);
    }
}
