using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeStats : MonoBehaviour
{
    List<GameObject> nextScreen = null;

    public void ShowStatsChange(int amount, string type, List<GameObject> nextScreen)
    {
        this.gameObject.SetActive(true);
        string text = $"Your {type} has changed by {amount}";
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
