using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour 
{
    void Awake()
    {
        // aby som vedel testovat aj ked nejdem z main menu, ale aby zaroven hra z main menu aj fungovala
        if(Languages.instance == null)
        {
            GameObject languagesPrefab = Resources.Load<GameObject>("Languages");
            Instantiate(languagesPrefab, transform);
        }
    }

    public void Start()
    {
        Application.targetFrameRate = 30;
    }
}
