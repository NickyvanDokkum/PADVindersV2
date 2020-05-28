using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCopier : MonoBehaviour
{
    [SerializeField] private Text thisText;
    [SerializeField] private Text textToCopy;
    void Update()
    {
        if(thisText.text != textToCopy.text) {
            thisText.text = textToCopy.text;
        }
    }
}
