using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoor : MonoBehaviour 
{
    public List<WoodenBarricade> barricades = new List<WoodenBarricade>();
    public Lock mainDoorLock;

    public void Interraction()
    {
        if(barricades.Count == 0 && mainDoorLock == null)
        {
            GameFinishedView.instance.ShowWinningPanel();
        }
    }
}
