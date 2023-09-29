using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeTower : MonoBehaviour
{
    public bool towerPlaced;
    [SerializeField] private SpriteRenderer sprite;
    void Start()
    {
        towerPlaced = false;
    }
    
    void Update()
    {
        if (!towerPlaced)
        {
            Vector3 Currentpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Currentpos.z = 0;
            transform.position = Currentpos;
        }
    }
}
