using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatusPlayerMovement : MonoBehaviour 
{
    private bool isCrouched = false;

    public CharacterController controller;
    public float speed = 12f;
    public AudioSource footstepSource;

    public void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if (isCrouched)
            move /= 2;

        controller.Move(move*speed*Time.deltaTime);

        // prikrcenie klavesnica
        if (Input.GetKeyDown(KeyCode.LeftControl))
            CrouchPressed();
    }

    public void LateUpdate()
    {
        if(controller.velocity != Vector3.zero)
        {
            if(!footstepSource.isPlaying)
                footstepSource.Play();            
        }
        else
        {
            if (footstepSource.isPlaying)
                footstepSource.Stop();
        }
    }

    public void CrouchPressed()
    {
        if (!isCrouched)
        {
            Vector3 delta = new Vector3(0, transform.localScale.y / 2, 0);
            controller.height = 1;
            transform.position -= delta;
            
            HUD.instance.hudCrouchControl.ShowCrouched();
        }
        else
        {
            Vector3 delta = new Vector3(0, transform.localScale.y, 0);
            controller.height = 2;
            //transform.position += delta;

            HUD.instance.hudCrouchControl.ShowStanding();
        }

        isCrouched = !isCrouched;
    }
}
