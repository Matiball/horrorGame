using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDDropItem : MonoBehaviour 
{
    public GameObject dropButton;

    public void ShowDropButton()
    {
        dropButton.SetActive(true);
    }

    public void HideDropButton()
    {
        dropButton.SetActive(false);
    }

    public void DropItemPressed()
    {

    }
}
