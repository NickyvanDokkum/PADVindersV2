using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneChild : MonoBehaviour
{
    public int maxChildAmount = 1;
    public Transform hand;

    public void Hand() {
        hand = transform.parent.parent.Find("Hand");    //zorgt voor een optie in unity waar je de returnparent kan kiezen wanneer de max children is bereikt
    }

    void Update()
    {
        if (transform.childCount >= maxChildAmount) //checkt of het max aantal children is bereikt
        {
            for (int i = maxChildAmount; i < transform.childCount; i++)
            {
                Debug.Log(transform.GetChild(i));
                transform.GetChild(i).SetParent(hand);  //wanneer max children is bereikt zet hij de parent naar de in Hand() geselecteerde parent
            }
        }
    }
}
