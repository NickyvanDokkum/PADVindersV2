using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEventScript : MonoBehaviour
{
    public void ActivateNewEvent() {
        Debug.Log(EventController.eventController);
        EventController.eventController.CreateEvent(new Event("New Title", "This is the new test body"));
    }
}
