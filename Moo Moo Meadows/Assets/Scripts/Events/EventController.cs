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

    private void Start() {
        _eventController = this;
        this.enabled = false;
    }

    public void CreateEvent(Event Event) {
        _title.text = Event.title;
        _body.text = Event.body;

        //TODO: TALK TO THE CARD SYSTEM
        _parent.SetActive(true);
        gameObject.SetActive(true);
    }

    public void PlayCard(CardStats[] cardStats) {
        //TODO: CHANGE STATS HERE DEPENDING ON WHAT CARD IS PLAYED
        Debug.Log(cardStats.Length);
        for (int i = 0; i < cardStats.Length; i++) {
            int[] stats = cardStats[i].GetStats();
            money.AddValue(stats[0]);
            hapiness.AddValue(stats[1]);
            grades.AddValue(stats[2]);
            health.AddValue(stats[3]);
            home.AddValue(stats[4]);
        }

        _parent.SetActive(false);
        _hub.SetActive(true);
        gameObject.SetActive(false);
    }
}
