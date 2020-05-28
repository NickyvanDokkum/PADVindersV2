using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeStats : MonoBehaviour
{
    List<GameObject> nextScreen = null;

    public void ShowStatsChange(List<GameObject> nextScreen, int healthAmount = 0, int stressAmount = 0, int gradesAmount = 0, int moneyAmount = 0, int homeAmount = 0)
    {
        this.gameObject.SetActive(true);
        string text = "Stats increase";

        //dit is om de tekst te maken
        if(healthAmount != 0)
        {
            text += $"\n Health {healthAmount}";
        }
        if (stressAmount != 0)
        {
            text += $"\n Happiness {stressAmount}";
        }
        if (gradesAmount != 0)
        {
            text += $"\n Grades {gradesAmount}";
        }
        if (moneyAmount != 0)
        {
            text += $"\n Money {moneyAmount}";
        }
        if (homeAmount != 0)
        {
            text += $"\n Home {homeAmount}";
        }
        
        //als er niks is verandert
        if(text == "Stats increase")
        {
            text += $"\n Nothing changed";
        }

        transform.Find("Text").GetComponent<Text>().text = text;

        this.nextScreen = nextScreen;
        foreach (GameObject screen in nextScreen)
        {
            screen.SetActive(false);
        }
    }

    public void GoToNextScreen()
    {
        foreach (GameObject screen in nextScreen)
        {
            screen.SetActive(true);
        }

        this.gameObject.SetActive(false);
    }
}
