using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour 
{
    public PickableItem.ItemType druhPredmetu;

    public enum ItemType
    {
        key,
        hammer,
    }

    public void Interraction()
    {
        PlayerInventory.instance.PickUpItem(gameObject);
    }
}
