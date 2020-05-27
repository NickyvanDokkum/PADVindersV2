using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventList : MonoBehaviour {
    public static EventList eventList {
        get { return _eventList; }
    }
    private static EventList _eventList;

    EventList() {
        _eventList = this;
    }

    public Event GetEvent(int eventNumber) {
        return structuredEvents[eventNumber];
    }

    public int GetEventAmount()
    {
        return structuredEvents.Count;
    }

    public Event GetRandomEvent() {
        int rand = Mathf.RoundToInt(Random.Range(0, events.Count-1));
        return events[rand];
    }


    private static readonly List<Event> events = new List<Event>() {
        new Event("Damages to your maintenance", "Your heater/fan/etc just broke. You tell your landlord about this and he says you need to pay it yourself."),
        new Event("Rent Increase", "Your landlord will be increasing your rent. But you just started living here! What will you do about it?"),
        new Event("Keys", "You lost your keys today and you cant enter your house. Your landlord can get you new keys for a pricey fee. What will you do?"),
        new Event("Rude invitation", "Your landlord enters your home without permission and is not willing to leave. What will you do?"),
        new Event("Extra service fees", "Your landlord tells you you knew about the costs but you cant find anything back in your documents or you want to remove them but you cant because the services are essential"),
        new Event("Noise complaint", "You just got informed you got a noise complaint. Your landlord tells you you need to pay a fine. But in the contract it only says you will receive warnings."),
        new Event("Pet/ abandoned puppy", "Your landlord says that animals are prohibited. What will you do?"),
        new Event("Painting", "While cooking you accidentally leave a burnmark on your wall and ceiling. What will you do?"),
        new Event("Flat tire right before school", "Your bike just got a flat tire. This is your only way of transportation. What will you do?")
        };


    private static readonly List<Event> structuredEvents = new List<Event>() {
        new Event("School or work", "Your team needs you at school to finish an assignment, but you need to go to work soon. What will you do?"),
        new Event("All-nighter", "Your friends are coming over to study for the exam week. Your landlord wants them to leave and is threatening you with a fine for letting other people stay in the house.")
        };
    }
