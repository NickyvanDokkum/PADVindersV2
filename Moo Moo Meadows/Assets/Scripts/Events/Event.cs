using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class is for easily creating and using events
public class Event
{
    //The title and body for the event
    public string title;
    public string body;

    //The constructor requires you to give a title and body when creating
    public Event(string Title, string Body) {
        title = Title;
        body = Body;
    }
}
