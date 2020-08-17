using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenBarricade : MonoBehaviour 
{
    private bool isRemoved = false;

    public MainDoor mainDoor;
    public AudioClip barricadeRemovedSound;

    public void RemoveBarricade()
    {
        if (isRemoved)
            return;
        else
            isRemoved = true;

        Rigidbody rigid = gameObject.GetComponent<Rigidbody>();

        rigid.isKinematic = false;
        rigid.useGravity = true;

        mainDoor.barricades.Remove(this);
        AudioSource.PlayClipAtPoint(barricadeRemovedSound, Camera.main.transform.position);
    }

    public void Interraction()
    {
        // ak ma hrac v ruke kladivo tak len vtedy zburat barikadu
        if(PlayerInventory.instance.pickedItem != null && PlayerInventory.instance.pickedItem.GetComponent<PickableItem>().druhPredmetu == PickableItem.ItemType.hammer)
        {
            RemoveBarricade();
        }
    }
}
