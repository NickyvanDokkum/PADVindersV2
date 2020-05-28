using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activities : MonoBehaviour
{

    [SerializeField] ChangeStats statsChange;
    [SerializeField] Calendar calendar;
    [SerializeField] private FillStatusBar status;
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
            EventController.eventController.StartRandomEvent();
        }

        ChangeStats(amount);

        switch (type)
        {
            case("money"):
                statsChange.ShowStatsChange(nextScreen, moneyAmount: amount);
                break;
            case ("stress"):
                statsChange.ShowStatsChange(nextScreen, stressAmount: amount);
                break;
            case ("home"):
                statsChange.ShowStatsChange(nextScreen, homeAmount: amount);
                break;
            case ("grades"):
                statsChange.ShowStatsChange(nextScreen, gradesAmount: amount);
                break;
        }
    }

    public virtual void ChangeStats(int amount)
    {
        status.AddValue(amount);
    }
}
