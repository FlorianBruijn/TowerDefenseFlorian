using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class enemy_Health : MonoBehaviour
{
    public float health;
    public float startHealth;

    [SerializeField] private path waypoints;
    [SerializeField] private gold money;
    [SerializeField] private Animator animator;
    void Start()
    {
        waypoints = FindAnyObjectByType<path>();
        health = startHealth;
        money = FindAnyObjectByType<gold>();
    }

    void Update()
    {
        if(health < startHealth / 2)
        {
            animator.SetBool("lesHeat", true);
        }
        if (health <= 0)
        {
            Debug.Log(waypoints.waypoints.Count);
            money.addMoney(waypoints.waypoints.Count / 10);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            bullet bullet = collision.GetComponent<bullet>();
            health -= bullet.damage;
            Destroy(collision.gameObject);
        }
    }
}
