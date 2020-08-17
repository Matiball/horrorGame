using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTrap : MonoBehaviour 
{
    public float sekundyNaUvolnenie = 3f;

    public AudioClip trappedSound, unlockedSound;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //drobit, vypnut mu pohybovanie, zobrazit button v HUDE na vyslobodenie z pasci, pridat zvuky na pascu
            AudioSource.PlayClipAtPoint(trappedSound, Camera.main.transform.position);
            ControlsManager.instance.DisableControlls();
            HUD.instance.hudTrapEscape.ShowHud(this);
        }
    }

    public void MakePlayerFree()
    {
        AudioSource.PlayClipAtPoint(unlockedSound, Camera.main.transform.position);

        ControlsManager.instance.EnableControlls();

        Destroy(gameObject);
    }
}
