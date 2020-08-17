using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingHand : MonoBehaviour 
{
    public AIController aIController;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            aIController.StopZombie();
            other.GetComponent<Player>().Die();
        }
    }
}
