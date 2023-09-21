using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aim : MonoBehaviour
{ 
    [SerializeField] private string enemyTag;
    [SerializeField] private shoot shoot;
    public float range;
    void Start()
    {
        
    }

    void Update()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag(enemyTag);
        if (targets.Length == 0) 
        {
            return; 
        }
        for (int i = 0; i < targets.Length; i++)
        {
            if (Vector3.Distance(targets[i].transform.position,transform.position) < range)
            {
                lookAtTarget(targets[i].transform);
                i = targets.Length;
            }
        }
    }
    void lookAtTarget(Transform target)
    {
        Vector2 direction = target.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
        shoot.shootProjectile(target);
    }
}
