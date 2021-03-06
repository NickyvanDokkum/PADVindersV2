﻿       using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FillStatusBar: MonoBehaviour
{
    public float currentStats;
    public float maxStats;
    public Image fillimage;
    private Slider slider;
    [SerializeField] private bool homeSlider = false; //To check if it's a win condition

    private bool started = false;

    // Start is called before the first frame update
    public void Start()
    {

        slider = GetComponent<Slider>();
        Debug.Log("slider start" + slider);
        ChangeValue();
    }

    //Deze funtie wordt aangeroepen als de stats veranderen en zorgt ervoor dat de verandering in de slider komt
    void ChangeValue()
    {
        if (!started)
        {
            started = !started;
            Start();
        }

        float fillValue = currentStats / maxStats;
        Debug.Log("slider" + slider);
        Debug.Log("slider value" + slider.value);
        slider.value = fillValue;

        //If the win slider is full or empty, it will load one of the game over screens
        if (homeSlider) {
            if (fillValue >= maxStats) {
                SceneManager.LoadScene(1); //This will load the win screen
            }
            else if (fillValue <= 0) {
                SceneManager.LoadScene(2); //This will load the lose screen
            }
        }
    }

    //Functie wordt gebruikt om de stats te veranderen
    public void SetStat(int stat)
    {
        currentStats = stat;
        ChangeValue();
    }

    //Functie wordt gebruikt om de stats te vergroten
    public void AddValue(int stat)
    {
        currentStats += stat;
        ChangeValue();
    }
    
}
