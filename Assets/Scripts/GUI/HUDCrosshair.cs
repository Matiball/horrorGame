using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDCrosshair : MonoBehaviour 
{
    public GameObject interractrionCircle;

    public void ShowInterractrion()
    {
        if(!interractrionCircle.activeSelf)
            interractrionCircle.SetActive(true);
    }

    public void HideInterraction()
    {
        if (interractrionCircle.activeSelf)
            interractrionCircle.SetActive(false);
    }
}
