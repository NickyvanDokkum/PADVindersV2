using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Calendar : MonoBehaviour
{
    List<DayInformation> plannedDays;
    public int currentDay;
    public Event todaysEvent;

    [SerializeField] EventList eventList;
    [SerializeField] GameObject day;

    string[] daysOfWeek;
    int dayOfWeek;

    //dit moet hier opgeslagen worden omdat het moet starten als het aan staat en als ik het uit ga zetten na elke dag gaat alles kapot
    public GameObject eventInfoViewer;

    // hierdoor kunnen de scripten van de weeken meeluisteren of er een week voorbij is
    public UnityEvent advanceWeek;


    public bool started = false;

    public void StartUp()
    {
        if (!started)
        {
            currentDay = 1;
            plannedDays = new List<DayInformation>();
            daysOfWeek = new string[7] {"Monday", "Teusday", "Wednesday", "Theurseday", "Friday", "Saturday", "Sunday"};
            dayOfWeek = 0;

            //dit hoort nog bij de event viewer
            //anders start hij pas nadat de eerste functie is uitgevoerd en dat werkt niet
            eventInfoViewer.SetActive(true);
            eventInfoViewer.GetComponent<ViewEventInfo>().Start();
            eventInfoViewer.SetActive(false);

            //plan de eerste 4 weken
            int numberOfWeeks = 4;
            for (int week = 0; week < numberOfWeeks; week++)
            {
                int plannedDay = currentDay + (week * 7);
                FillWeek(plannedDay);
            }
            todaysEvent = GetTodaysEvent();
        }
    }

    public void AdvanceDay()
    //elke dag is er ook nog een structured event maar daar hoef ik niks mee te doen
    {

        currentDay++;
        dayOfWeek++;

        //check of de week is afgelopen om vervolgens de huur te betalen
        if (currentDay % 7 == 1)
        {
            dayOfWeek = 0;

            int deletedDays = 0;

            //verwijder de dingen uit de list van de vorige week
            for (int index = plannedDays.Count - 1; index >= 0; index--)
            {
                DayInformation plannedDay = plannedDays[index];

                if (plannedDay.day < currentDay)
                {
                    deletedDays++;
                    plannedDays.Remove(plannedDay);

                    if(deletedDays == 7)
                    {
                        break;
                    }

                }
            }

            //plan events voor de nieuwe week
            int weeks = 3;
            int daysInWeek = 7;
            FillWeek(currentDay + (weeks * daysInWeek));

            advanceWeek.Invoke();
        }

        todaysEvent = GetTodaysEvent();
        day.GetComponent<Text>().text = daysOfWeek[dayOfWeek];
    }

    public Event GetEventForDay(int day)
    {
        foreach (DayInformation plannedDay in plannedDays)
        {
            if(plannedDay.day == day)
            {
                return plannedDay.cardEvent;
            }
        }

        return null;
    }

    public void PlanEvent(int day, Event cardEvent)
    {
        plannedDays.Add(new DayInformation(day, cardEvent));
    }

    void FillWeek(int startDay)
    {
        int changeForEvent = 40;
        for (int day = 0; day < 7; day++)
        {
            //get random change for event
            if(Random.Range(1, 100) <= changeForEvent)
            {
                //plan a random structured event
                int  eventsAmount = eventList.GetEventAmount();
                //put the event in the calendar
                PlanEvent(startDay + day,
                //get the event from the eventlist
                eventList.GetEvent(Random.Range(0, eventsAmount)));
            }
        }
    }

    Event GetTodaysEvent()
    {
        foreach (DayInformation plannedDay in plannedDays)
        {

            if (plannedDay.day == currentDay)
            {
                return plannedDay.cardEvent;
            }
        }

        return null;
    }

    class DayInformation
    {
        public int day;
        public Event cardEvent;

        public DayInformation(int day, Event cardEvent)
        {
            this.day = day;
            this.cardEvent = cardEvent;
        }
    }
}
