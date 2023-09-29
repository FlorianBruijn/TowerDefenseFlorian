using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Health : MonoBehaviour
{
    public float health;
    public float startHealth;
    [SerializeField] private Animator animator;
    void Start()
    {
        health = startHealth;
    }

    void Update()
    {
        if(health < startHealth / 2)
        {
            animator.SetBool("lesHeat", true);
        }
        if (health <= 0)
        {
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
