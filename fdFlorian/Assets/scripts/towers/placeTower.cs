using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeTower : MonoBehaviour
{
    [SerializeField] private bool canPlace;
    public bool towerPlaced;
    [SerializeField] private SpriteRenderer sprite;
    void Start()
    {
        towerPlaced = false;
        canPlace = true;
    }
    
    void Update()
    {
        if (!towerPlaced)
        {
            Vector3 Currentpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Currentpos.z = 0;
            transform.position = Currentpos;
            if(canPlace && Input.GetMouseButtonDown(0))
            {
                towerPlaced = true;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "tower" || collision.gameObject.tag == "path")
        {
            canPlace = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "tower" || collision.gameObject.tag == "path")
        {
            canPlace = true;
        }
    }
}
