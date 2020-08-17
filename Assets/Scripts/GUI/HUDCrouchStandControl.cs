using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDCrouchStandControl : MonoBehaviour 
{
    public GameObject crouchImage, standImage;

    public void ShowCrouched()
    {
        standImage.SetActive(false);
        crouchImage.SetActive(true);
    }

    public void ShowStanding()
    {
        standImage.SetActive(true);
        crouchImage.SetActive(false);
    }
}
