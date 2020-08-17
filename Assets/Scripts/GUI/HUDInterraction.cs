using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDInterraction : MonoBehaviour 
{
    public GameObject interractButton;

    public void ShowInterractButton()
    {
        if(!interractButton.activeSelf)
            interractButton.SetActive(true);
    }

    public void HideInterractButton()
    {
        if (interractButton.activeSelf)
            interractButton.SetActive(false);
    }

    public void InterractionHandDown()
    {
        MobileInputNew.interractionHand = true;
    }

    public void InterractionHandUp()
    {
        MobileInputNew.interractionHand = false;
    }
}
