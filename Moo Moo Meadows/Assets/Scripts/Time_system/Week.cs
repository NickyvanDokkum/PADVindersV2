using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Week : MonoBehaviour
{

    public int thisWeek;
    Text weekText;

    // Start is called before the first frame update
    void Start()
    {

        weekText = transform.Find("Text").GetComponent<Text>();

        //remove the "week " part of the text and convert it to an int
        thisWeek = int.Parse(weekText.text.Remove(0,5));


        Calendar calendar;
        calendar = this.GetComponentInParent<Calendar>();

        //hierdoor luistert hij of er een week voorbij is
        calendar.advanceWeek.AddListener(advanceWeek);
    }

    void advanceWeek()
    {
        thisWeek++;
        weekText.text = "Week " + thisWeek;
    }
    //dan moet ik alleen nog even iets bedenken zodat hij ze ook gaat updaten

    //misschien een listener
}
