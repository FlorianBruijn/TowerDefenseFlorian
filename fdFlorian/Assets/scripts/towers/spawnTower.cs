using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTower : MonoBehaviour
{
    [SerializeField] private GameObject tower;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void onButton()
    {
        Instantiate(tower);
    }
}
