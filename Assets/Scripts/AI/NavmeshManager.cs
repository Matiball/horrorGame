using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavmeshManager : MonoBehaviour 
{
    public static NavmeshManager instance;
    public Transform[] randomPoints;

    public void Awake()
    {
        instance = this;
    }

    public Transform GetRandomPoint()
    {
        return randomPoints[Random.Range(0, randomPoints.Length)];
    }
}
