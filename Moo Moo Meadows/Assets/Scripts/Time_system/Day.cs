using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day : MonoBehaviour
{
    public Event eventData;
    int DayOfWeek;
    Calendar calendar;
    GameObject eventInfoViewer;
    GameObject calendarUI;
    Week week;

    Button thisButton;
    Color startingColor;

    // Start is called before the first frame update
    public void Start()
    {
        calendar = this.GetComponentInParent<Calendar>();
        eventInfoViewer = GameObject.Find("Structured event change");
        calendarUI = GameObject.Find("Calendar");
        week = this.GetComponentInParent<Week>();
        thisButton = this.GetComponent<Button>();
        startingColor = thisButton.colors.normalColor;

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
    }

    void AdvanceWeek()
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

    public void ShowEventInfo()
    {
        if (this.eventData != null)
        {
            eventInfoViewer.SetActive(true);
            eventInfoViewer.GetComponent<ViewEventInfo>().ShowEvent(eventData);
            calendarUI.SetActive(false);
        }
    }
}
