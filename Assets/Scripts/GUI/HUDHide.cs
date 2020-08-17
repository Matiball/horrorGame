using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class HUDHide : MonoBehaviour 
{
    private Bed hidingBed;

    public GameObject buttonUnhide;


    // ak by sa hrac schovaval v skrini alebo hocikde inde, tak sa jednoducho pretazi metoda s inym parametrom, zatial je to len takto, lebo som spravil len pod postel
    public void ShowUnhideButton(Bed bedWherePlayerHiding)
    {
        hidingBed = bedWherePlayerHiding;
        buttonUnhide.SetActive(true);        
    }

    public void Unhide()
    {
        hidingBed.Unhide();
        buttonUnhide.SetActive(false);
        hidingBed = null;
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (hidingBed != null)
                Unhide();
        }
    }
}
