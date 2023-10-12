using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTower : MonoBehaviour
{
    [SerializeField] private GameObject tower;
    [SerializeField] private GameObject lastPlaced;
    
    public void onButton()
    {
        bool canSpawn = true;
        if (lastPlaced != null)
        {
            placeTower place = lastPlaced.GetComponent<placeTower>();
            if (!place.towerPlaced)
            {
                canSpawn = false;
            }
        }

        Debug.Log(canSpawn);
        if(canSpawn)
        {
            lastPlaced = Instantiate(tower);
        }
    }
}
