using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gold : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    public float goldCount;
    void Start()
    {
        goldCount = 10;
    }
    private void Update()
    {
        text.text = "money : " + goldCount;
    }

    public void addMoney(float ammount)
    {
        goldCount += ammount;
    }

    public void removeMoney(float ammount)
    {
        goldCount -= ammount;
    }
}
