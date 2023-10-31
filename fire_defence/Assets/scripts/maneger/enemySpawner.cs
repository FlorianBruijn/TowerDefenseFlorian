using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public int wave = 1;
    public int dificulty;
    public int currentEnemy;
    [SerializeField] private float speed = 1;
    [SerializeField] private float wait = 1;
    [SerializeField] private float hp = 1;
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
            if(done.Done)
            {
                if(wait == 5){
                    wave ++;
                    currentEnemy = 0;
                    maxEnemy = wave * 2 + 2;
                    wait = 1;
                }
                if(!(currentEnemy == maxEnemy)){
                    GameObject enemy = Instantiate(enemyPrefab);
                    waypointFolower folower = enemy.GetComponent<waypointFolower>();
                    enemy_Health health = enemy.GetComponent<enemy_Health>();
                    health.startHealth = hp;
                    folower.speed = speed;
                    hp = wave;
                    currentEnemy ++;
                }
                else{
                    wait = 5;
                }
            }
                yield return new WaitForSeconds(wait);
        }
    }
}
