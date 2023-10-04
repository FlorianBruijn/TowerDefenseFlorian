using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class takeDamage : MonoBehaviour
{
    [SerializeField] private TMP_Text hpText;
    [SerializeField] private int hp;
    void Start()
    {
        hp = 20;
    }

    void Update()
    {
        hpText.text = "hp " + hp + " / 20";
        if (hp == 0) 
        {
            SceneManager.LoadScene(2);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "enemy")
        {
            hp--;
        }
    }
}
