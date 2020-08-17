using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    private Animator animator;
    private AudioSource audioSource;

    public bool isDoorClosed = true;
    public AudioClip doorClosingSound, doorOpeningSound;

    public void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void DoorInterraction()
    {
        // ak sa este dvere zatvaraju alebo este otvaraju tak nevykonat ziadnu akciu
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
            return;

        // otvorenie dveri
        if (isDoorClosed)
        {
            animator.SetBool("open", true);
            audioSource.clip = doorOpeningSound;
            audioSource.Play();

        }
        // zatvorenie dveri
        else if (!isDoorClosed)
        {
            animator.SetBool("open", false);
            audioSource.clip = doorClosingSound;
            audioSource.Play();
        }


        isDoorClosed = !isDoorClosed;
    }

    public void Interraction()
    {
        DoorInterraction();
    }
}
