using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day : MonoBehaviour
{
    public Event eventData;
    int DayOfWeek;
    Calendar calendar;
    GameObject calendarUI;
    Week week;

    Button thisButton;
    Color startingColor;

    // Start is called before the first frame update
    public void Start()
    {
        calendar = this.GetComponentInParent<Calendar>();
        calendarUI = GameObject.Find("Calendar");
        week = this.GetComponentInParent<Week>();
        thisButton = this.GetComponent<Button>();
        startingColor = thisButton.colors.normalColor;
        calendar.StartUp();
        week.StartUp();

        //hierdoor luistert hij of er een week voorbij is
        week.advanceToNextWeek.AddListener(AdvanceWeek);


        string dayText = transform.Find("Text").GetComponent<Text>().text.Trim().ToLower();
        switch (dayText)
        {
            case ("monday"):
                DayOfWeek = 1;
                break;
            case ("tuesday"):
                DayOfWeek = 2;
                break;
            case ("wednesday"):
                DayOfWeek = 3;
                break;
            case ("thursday"):
                DayOfWeek = 4;
                break;
            case ("friday"):
                DayOfWeek = 5;
                break;
            case ("saturday"):
                DayOfWeek = 6;
                break;
            case ("sunday"):
                DayOfWeek = 7;
                break;
        }

        ShowTodaysEvent();
    }

    void AdvanceWeek()
    {
        ShowTodaysEvent();
    }

    public void ShowEventInfo()
    {
        if (this.eventData != null)
        {
            calendar.eventInfoViewer.SetActive(true);
            calendar.eventInfoViewer.GetComponent<ViewEventInfo>().ShowEvent(eventData);
            calendarUI.SetActive(false);
        }
    }

    void ShowTodaysEvent()
    {
        int weekOffset = -1;
        this.eventData = calendar.GetEventForDay((week.thisWeek + weekOffset) * 7 + DayOfWeek);

        //verander de kleur van dagen met ingeplande events
        ColorBlock buttonColor = thisButton.colors;
        if (this.eventData != null)
        {
            buttonColor.normalColor = Color.cyan;
        }
        else
        {
            buttonColor.normalColor = startingColor;
        }
        thisButton.colors = buttonColor;
    }
}
