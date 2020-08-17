using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour 
{
    public static PlayerInventory instance;

    public Player player;
    public Transform itemPlaceholder;
    public GameObject pickedItem;

    public void Awake()
    {
        instance = this;
    }

    public void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            ThrowItem();
        }
    }

    public void PickUpItem(GameObject item)
    {
        if (pickedItem != null)
            return;

        HUD.instance.hudDropItem.ShowDropButton();
        pickedItem = item;
        item.GetComponent<Rigidbody>().isKinematic = true;

        pickedItem.transform.parent = itemPlaceholder;

        pickedItem.transform.localPosition = Vector3.zero;
        pickedItem.transform.localRotation = Quaternion.identity;
        pickedItem.transform.localScale = Vector3.one;
    }

    public void ThrowItem()
    {
        if (pickedItem == null)
            return;

        HUD.instance.hudDropItem.HideDropButton();
        pickedItem.GetComponent<Rigidbody>().isKinematic = false;
        pickedItem.transform.parent = null;
        pickedItem = null;
    }
}
