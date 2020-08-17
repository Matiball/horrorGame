using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaryNoiseObject : MonoBehaviour 
{
    private bool alreadyUsed;

    public float xPower, yPower, zPower;
    public ForceMode forceMod;

    public AudioClip[] scaryEffects;

    public void OnTriggerEnter(Collider other)
    {
        if (alreadyUsed || other.tag != "Player")
            return;

        alreadyUsed = true;

        Rigidbody rgb = gameObject.GetComponent<Rigidbody>();
        rgb.isKinematic = false;

        AudioSource.PlayClipAtPoint(RandomScarySound() ,Camera.main.transform.position);

        rgb.AddForce(new Vector3(xPower, yPower, zPower), forceMod);
    }

    
    public AudioClip RandomScarySound()
    {
        return scaryEffects[Random.Range(0, scaryEffects.Length)];
    }
}
