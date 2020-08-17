﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatusMouseLook : MonoBehaviour 
{
    private float xRotation = 0;

    public float mouseSensitivity = 100f;
    public Transform player;

    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        player.Rotate(Vector3.up, mouseX);        
    }
}
