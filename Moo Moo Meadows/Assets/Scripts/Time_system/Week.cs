using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Week : MonoBehaviour
{

    public int thisWeek;
    Text weekText;

    //deze heeft zijn eigen functie omdat het anders in de verkeerde volgorde kan gaan met de dagen en de weken
    public UnityEvent advanceToNextWeek;

    bool started = false;

    // Start is called before the first frame update
    public void StartUp()
    {
        if (!started)
        {
            started = true;
            weekText = transform.Find("Text").GetComponent<Text>();

            //remove the "week " part of the text and convert it to an int
            thisWeek = int.Parse(weekText.text.Remove(0,5));


            Calendar calendar;
            calendar = this.GetComponentInParent<Calendar>();

            //hierdoor luistert hij of er een week voorbij is
            calendar.advanceWeek.AddListener(AdvanceWeek);
        }
    }

    void AdvanceWeek()
    {
        thisWeek++;
        weekText.text = "Week " + thisWeek;
        advanceToNextWeek.Invoke();
    }
}
