using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interraction : MonoBehaviour 
{
    public void Interract()
    {
        gameObject.SendMessage("Interraction", SendMessageOptions.RequireReceiver);
    }
}
