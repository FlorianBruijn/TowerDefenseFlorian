using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class spawnTower : MonoBehaviour
{
    [SerializeField] private GameObject tower;
    [SerializeField] private GameObject lastPlaced;
    [SerializeField] private gold gold;
    [SerializeField] private float cost = 0;
    [SerializeField] private float costIncrese = 5;
    [SerializeField] private TMP_Text text;
    
    private void Start() 
    {
        text.text = "cost\n" + cost;
    }

    public void onButton()
    {
        bool canSpawn = true;
        if (lastPlaced != null)
        {
            placeTower place = lastPlaced.GetComponent<placeTower>();
            if (!place.towerPlaced || gold.goldCount < cost)
            {
                canSpawn = false;
            }
        }

        Debug.Log(canSpawn);
        if(canSpawn)
        {
            lastPlaced = Instantiate(tower);
            gold.removeMoney(cost);
            cost += costIncrese;
            text.text = "cost\n" + cost;
        }
    }
}
