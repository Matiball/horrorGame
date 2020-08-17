using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInterraction : MonoBehaviour
{
    public LayerMask maskToInterract;
    public float distanceToInterract;

    public PlayerInventory inventory;

    public void Update()
    {
        // ak je predomnou nejaky objekt na interract
        RaycastHit raycastHit;
        if (Physics.Raycast(transform.position, transform.forward, out raycastHit, distanceToInterract, maskToInterract))
        {
            HUD.instance.hudCrosshair.ShowInterractrion();
            HUD.instance.hudInterraction.ShowInterractButton();

            // ak stlacam tlacidlo na predmet
            if(Input.GetMouseButtonDown(0) || MobileInputNew.interractionHand)
            {
                // kazdy objekt s ktrorym sa bude ineragovat bude mat Interraction skript a ten nasledne posle spravu vsetkym skriptom na objekte, ze sa vykonala interakcia
                raycastHit.collider.gameObject.GetComponent<Interraction>().Interract();
            }

        }
        else
        {
            HUD.instance.hudCrosshair.HideInterraction();
            HUD.instance.hudInterraction.HideInterractButton();
        }
    }
}
