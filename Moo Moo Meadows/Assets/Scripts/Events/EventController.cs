using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventController : MonoBehaviour {

    //The eventController function returns the only version of EventController
    public static EventController eventController {
        get { return _eventController; }
    }
    //the _eventController is the only version of the EventController
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

    //The constructor adds the created script to _eventController
    EventController() {
        _eventController = this;
    }

    //This function will start a specific structured event
    public void StartSpecificEvent(int eventNum) {
        Event chosen = EventList.eventList.GetEvent(eventNum);
        CreateEvent(chosen);
    }

    //This function will start a random event
    public void StartRandomEvent() {
        Event chosen = EventList.eventList.GetRandomEvent();
        CreateEvent(chosen);
    }

    //The CreateEvent function makes the event received viewable in the event screen
    public void CreateEvent(Event Event) {
        _title.text = Event.title;
        _body.text = Event.body;

        KaartInfo.eventnaam = Event.title;

        _parent.SetActive(true);
        gameObject.SetActive(true);
    }

    //The PlayCard function is called when a card is played and changes stats corrosponding to the card played
    //After that it calls the change stat screen
    public void PlayCard(CardStats[] cardStats) {
        //Creates the stats so stats can be added
        int moneyAmount = 0;
        int hapinessAmount = 0;
        int gradesAmount = 0;
        int healthAmount = 0;
        int homeAmount = 0;

        //This goes through the list of cards and adds the corrosponding stats
        for (int i = 0; i < cardStats.Length; i++) {
            int[] stats = cardStats[i].GetStats();
            moneyAmount += stats[0];
            hapinessAmount += stats[1];
            gradesAmount += stats[2];
            healthAmount += stats[3];
            homeAmount += stats[4];
        }

        //This changes the stats directly
        money.AddValue(moneyAmount);
        hapiness.AddValue(hapinessAmount);
        grades.AddValue(gradesAmount);
        health.AddValue(healthAmount);
        home.AddValue(homeAmount);

        //This opens the change stat screen and disables the event and card screen.
        _parent.SetActive(false);
        _hub.SetActive(true);
        List<GameObject> hub = new List<GameObject>();
        hub.Add(_hub);
        changeStatsScreen.ShowStatsChange(hub, moneyAmount: moneyAmount, stressAmount: hapinessAmount, gradesAmount: gradesAmount, healthAmount: healthAmount, homeAmount: homeAmount);
        calendar.AdvanceDay();
        gameObject.SetActive(false);
    }
}
