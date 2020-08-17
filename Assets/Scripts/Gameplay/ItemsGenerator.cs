using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemsGenerator : MonoBehaviour 
{
    public List<GameObject> listOfSpawnPoints = new List<GameObject>();

    public GameObject[] itemsToGenerate;

    public void Start()
    {
        listOfSpawnPoints = GameObject.FindGameObjectsWithTag("ItemSpawnPoint").ToList<GameObject>();

        foreach(GameObject item in itemsToGenerate)
        {
            int randomIndex = Random.Range(0, listOfSpawnPoints.Count);
            
            Instantiate(item, listOfSpawnPoints[randomIndex].transform.position, Quaternion.identity, listOfSpawnPoints[randomIndex].transform);
            listOfSpawnPoints.RemoveAt(randomIndex);
        }
    }
}
