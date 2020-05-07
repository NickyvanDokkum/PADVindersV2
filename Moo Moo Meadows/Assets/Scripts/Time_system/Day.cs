using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day : MonoBehaviour
{
    public test_event_data eventData;
    int DayOfWeek;
    Calendar calendar;
    Week week;

    // Start is called before the first frame update
    public void Start()
    {
        calendar = this.GetComponentInParent<Calendar>();
        week = this.GetComponentInParent<Week>();

        //hierdoor luistert hij of er een week voorbij is
        calendar.advanceWeek.AddListener(AdvanceWeek);


        string dayText = transform.Find("Text").GetComponent<Text>().text.Trim();
        switch (dayText)
        {
            case ("Monday"):
                DayOfWeek = 0;
                break;
            case ("Theusday"):
                DayOfWeek = 1;
                break;
            case ("Wednesday"):
                DayOfWeek = 2;
                break;
            case ("Thursday"):
                DayOfWeek = 3;
                break;
            case ("Friday"):
                DayOfWeek = 4;
                break;
            case ("Saturday"):
                DayOfWeek = 5;
                break;
            case ("Sunday"):
                DayOfWeek = 6;
                break;
        }
    }

    void AdvanceWeek()
    {
        this.eventData = calendar.GetEventForDay((week.thisWeek*7) + DayOfWeek);
    }
}
