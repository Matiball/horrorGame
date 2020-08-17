using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour 
{
    public static HUD instance;

    public HUDMessage hudMessage;
    public HUDCrouchStandControl hudCrouchControl;
    public HUDHide hudHideControl;
    public HUDInterraction hudInterraction;
    public HUDDropItem hudDropItem;
    public HUDCrosshair hudCrosshair;
    public HudTrapEscape hudTrapEscape;

    public void Awake()
    {
        instance = this;
    }


}
