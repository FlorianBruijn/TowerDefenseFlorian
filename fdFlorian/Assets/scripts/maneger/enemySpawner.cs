using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
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
                Instantiate(enemyPrefab);
            }
        }
    }
}
