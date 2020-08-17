using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDMessage : MonoBehaviour 
{
    private bool isTextShowed;

    public Text messageTextfield;

    public void ShowMessageWithTimer(string messageText, float timeToShow)
    {
        if (isTextShowed)
            return;

        StartCoroutine(ShowMessage(messageText, timeToShow));
    }

    public IEnumerator ShowMessage(string message, float time)
    {
        messageTextfield.enabled = true;
        messageTextfield.text = message;

        yield return new WaitForSeconds(time);
        messageTextfield.enabled = false;
    }
}
