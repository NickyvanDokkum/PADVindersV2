using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activities : MonoBehaviour
{

    [SerializeField] ChangeStats statsChange;
    [SerializeField] Calendar calendar;
    [SerializeField] private FillStatusBar status;
    [SerializeField] EventController eventController;
    [SerializeField] List<GameObject> nextScreen;
    [SerializeField] private string type;
    [SerializeField] private int amount;

    public virtual void StartEvent()
    {
        if (calendar.todaysEvent != null)
        {
            EventController.eventController.CreateEvent(calendar.todaysEvent);
        }
        else
        {
            //start een random event maar dat zit er nog niet in
            eventController.CreateEvent(new Event("New new Title", "This is the new new test test body"));
        }
        ChangeStats(amount);
        statsChange.ShowStatsChange(amount, type, nextScreen);
    }

    public virtual void ChangeStats(int amount)
    {
        status.AddValue(amount);
    }
}
