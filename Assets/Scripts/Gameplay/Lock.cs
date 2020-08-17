using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour 
{
    public MainDoor mainDoor;
    public AudioClip lockUnlockedSound;

    public void RemoveLock()
    {
        Rigidbody rigid = gameObject.GetComponent<Rigidbody>();
        AudioSource.PlayClipAtPoint(lockUnlockedSound, Camera.main.transform.position);

        rigid.isKinematic = false;
        rigid.useGravity = true;

        mainDoor.mainDoorLock = null;
    }

    public void Interraction()
    {
        // ak ma hrac v ruke kladivo tak len vtedy zburat barikadu
        if (PlayerInventory.instance.pickedItem != null && PlayerInventory.instance.pickedItem.GetComponent<PickableItem>().druhPredmetu == PickableItem.ItemType.key)
        {
            RemoveLock();
        }
    }
}
