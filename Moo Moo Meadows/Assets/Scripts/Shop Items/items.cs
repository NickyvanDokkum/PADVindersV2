using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class items : MonoBehaviour
{
    [SerializeField] private moneyValue money;
    [SerializeField] private FillStatusBar Healthstat;
    [SerializeField] private FillStatusBar Happinessstat;
    [SerializeField] private FillStatusBar Gradesstat;
    [SerializeField] private FillStatusBar Karmastat;

    
    //hoeveel t item kost
    private int itemValue ;


   
    public void ItemMedicine()
    {
        
        Debug.Log(money.money);
        if (money.money >= 50 )
        {
            //remove money for item
            money.AddValue(-50);
            // give stat buffs
            Healthstat.AddValue(30);
        }
        else { }

    }


    public void ItemDataBundle()
    {

        Debug.Log(money.money);
        if (money.money >= 100)
        {
            //remove money for item
            money.AddValue(-100);
            // give stat buffs
            Happinessstat.AddValue(10);
        }
        else { }
    }


    public void ItemCheatSheet()
    {

        Debug.Log(money.money);
        if (money.money >= 100)
        {
            //remove money for item
            money.AddValue(-100);
            // give stat buffs
            Gradesstat.AddValue(10);
        }
        else { }
    }

    public void ItemGoldenTicket()
    {

        Debug.Log(money.money);
        if (money.money >= 300)
        {
            //remove money for item
            money.AddValue(-300);
            // give stat buffs
            Karmastat.AddValue(15);
        }
        else { }
    }
}