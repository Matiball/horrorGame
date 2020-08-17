using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
    public bool isDead { get; set; }
    public static int DaysRemaining = 5;

    public ControlsManager controls;
    public AudioClip dyingScream;

    public void Die()
    {
        if (isDead)
            return;

        Player.DaysRemaining--;
        controls.DisableControlls();
        AudioSource.PlayClipAtPoint(dyingScream, transform.position);
        isDead = true;

        GameFailedView.instance.OpenEndPanel();
    }
}
