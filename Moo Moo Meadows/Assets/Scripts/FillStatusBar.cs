       using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillStatusBar: MonoBehaviour
{
    public float currentStats;
    public float maxStats;
    public Image fillimage;
    private Slider slider;

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
