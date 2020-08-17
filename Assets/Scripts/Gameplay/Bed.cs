using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour 
{
    private GameObject player;
    private bool hidden;

    public GameObject bedCamera;

    public void Interraction()
    {
        if (!hidden && !AIController.instance.seeEnemy)
            HideUnderBed();       
    }
        

    public void HideUnderBed()
    {
        // zobrazi tlacidlo na unhide
        HUD.instance.hudHideControl.ShowUnhideButton(this);

        hidden = true;
        player = PlayerInventory.instance.gameObject;
        player.SetActive(false);

        bedCamera.SetActive(true);
    }

    public void Unhide()
    {
        hidden = false;
        bedCamera.SetActive(false);
        player.SetActive(true);        
    }
}
