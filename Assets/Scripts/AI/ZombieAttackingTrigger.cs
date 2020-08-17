using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttackingTrigger : MonoBehaviour 
{
    public Animator animator;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetInteger("Attack", 1);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetInteger("Attack", 0);
        }
    }
}
