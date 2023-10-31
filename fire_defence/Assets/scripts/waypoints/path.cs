using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour
{
    public List<Vector3> waypoints = new List<Vector3>();

    [SerializeField] private EdgeCollider2D col;

    public List<Vector2> colPoints = new List<Vector2>();
    public void setCol() 
    { 
        col.points = colPoints.ToArray();
    }
}
