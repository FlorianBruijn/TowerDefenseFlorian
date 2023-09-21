using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public int wave = 1;
    public int dificulty;
    public int currentEnemy;
    [SerializeField] private int maxEnemy;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private draw_path done;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            if (done.Done)
            {
                if (currentEnemy < maxEnemy)
                {

                }
                Instantiate(enemyPrefab);
            }
        }
    }
}
