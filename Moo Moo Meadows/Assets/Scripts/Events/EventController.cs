using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventController : MonoBehaviour {
    public static EventController eventController {
        get { return _eventController; }
    }
    private static EventController _eventController;


    [SerializeField] private Text _title = null;
    [SerializeField] private Text _body = null;
    [SerializeField] private GameObject _parent = null;
    [SerializeField] private GameObject _hub = null;

    [SerializeField] private moneyValue money;
    [SerializeField] private FillStatusBar hapiness;
    [SerializeField] private FillStatusBar grades;
    [SerializeField] private FillStatusBar health;
    [SerializeField] private FillStatusBar home;

    [SerializeField] private ChangeStats changeStatsScreen;
    [SerializeField] private Calendar calendar;

    EventController() {
        _eventController = this;
    }

    public void StartSpecificEvent(int eventNum) {
        Event chosen = EventList.eventList.GetEvent(eventNum);
        CreateEvent(chosen);
    }

    public void StartRandomEvent() {
        Event chosen = EventList.eventList.GetRandomEvent();
        CreateEvent(chosen);
    }

    public void CreateEvent(Event Event) {
        _title.text = Event.title;
        _body.text = Event.body;

        KaartInfo.eventnaam = Event.title;

        _parent.SetActive(true);
        gameObject.SetActive(true);
    }

    public void PlayCard(CardStats[] cardStats) {
        //TODO: CHANGE STATS HERE DEPENDING ON WHAT CARD IS PLAYED
        int moneyAmount = 0;
        int hapinessAmount = 0;
        int gradesAmount = 0;
        int healthAmount = 0;
        int homeAmount = 0;
        Debug.Log(cardStats.Length);
        for (int i = 0; i < cardStats.Length; i++) {
            int[] stats = cardStats[i].GetStats();
            moneyAmount += stats[0];
            hapinessAmount += stats[1];
            gradesAmount += stats[2];
            healthAmount += stats[3];
            homeAmount += stats[4];
        }

        money.AddValue(moneyAmount);
        hapiness.AddValue(hapinessAmount);
        grades.AddValue(gradesAmount);
        health.AddValue(healthAmount);
        home.AddValue(homeAmount);

        _parent.SetActive(false);
        _hub.SetActive(true);
        List<GameObject> hub = new List<GameObject>();
        hub.Add(_hub);
        changeStatsScreen.ShowStatsChange(hub, moneyAmount: moneyAmount, stressAmount: hapinessAmount, gradesAmount: gradesAmount, healthAmount: healthAmount, homeAmount: homeAmount);
        calendar.AdvanceDay();
        gameObject.SetActive(false);
    }
}
