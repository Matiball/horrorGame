using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlacer : MonoBehaviour
{
    public int secondsPeriodToPlaceBeartrap = 5;
    public LayerMask groundMask;

    public GameObject bearTrap;

    public void Start()
    {
        StartCoroutine(BearTrapTimer());
    }

    public IEnumerator BearTrapTimer()
    {
        while (true)
        {
            PlaceBearTrap();
            yield return new WaitForSeconds(secondsPeriodToPlaceBeartrap);
        }
    }

    public void PlaceBearTrap()
    {
        RaycastHit raycastHit;

        if (Physics.Raycast(transform.position, -transform.up, out raycastHit, Mathf.Infinity, groundMask))
        {
            Instantiate(bearTrap, raycastHit.point, Quaternion.identity);
        }
    }
}
