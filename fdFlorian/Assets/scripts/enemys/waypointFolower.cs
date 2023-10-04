using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypointFolower : MonoBehaviour
{ 
    [SerializeField] private Vector3[] waypoints;
    [SerializeField] private path maneger;
    [SerializeField] private float speed = 1;
    [SerializeField] private int nextWaypointIndex = 1;
    [SerializeField] private float reachedWaypointClearance = 0.25f;

    private void Awake()
    {
        maneger = FindAnyObjectByType<path>();
    }
    void Start()
    {
        waypoints = maneger.waypoints.ToArray();
        Debug.Log(maneger.waypoints.Count);
        transform.position = waypoints[0];
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[nextWaypointIndex], Time.deltaTime * speed);
        if(Vector3.Distance(transform.position, waypoints[nextWaypointIndex]) <= reachedWaypointClearance)
        {
            nextWaypointIndex++;
        }
        if(nextWaypointIndex >= waypoints.Length)
        {
            Destroy(gameObject);
        }
    }
}
