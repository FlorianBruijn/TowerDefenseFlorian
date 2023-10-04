using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draw_path : MonoBehaviour
{
    [SerializeField] private GameObject playerBase;
    private LineRenderer path;
    [SerializeField] private path waypoint;
    private Vector3 previouspos;

    [SerializeField] private Transform start;
    [SerializeField] private Transform finish;

    public string starttag = "enemyBase";
    public bool canStart;
    public bool drawing;
    public bool Stop;
    public bool Done;

    [SerializeField] private float minDist = 1f;
    void Start()
    {
        path = GetComponent<LineRenderer>();
        previouspos = transform.position;
    }

    void Update()
    {
        if (!Done)
        {
            if (Input.GetMouseButtonDown(0) && canStart)
            {
                drawing = true;
            }
            if (drawing)
            {
                Vector3 Currentpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Currentpos.z = 0;

                if (Vector3.Distance(Currentpos, previouspos) > minDist)
                {
                    if (previouspos == transform.position)
                    {
                        path.SetPosition(0, Currentpos);
                        waypoint.waypoints.Add(Currentpos);
                        waypoint.colPoints.Add(Currentpos);
                    }
                    else
                    {
                        path.positionCount++;
                        path.SetPosition(path.positionCount - 1, Currentpos);
                        waypoint.waypoints.Add(Currentpos);
                        waypoint.colPoints.Add(Currentpos);
                    }
                    previouspos = Currentpos;
                }
            }
            if (Stop)
            {
                waypoint.waypoints.Add(playerBase.transform.position);
                path.positionCount++;
                Vector3 currentPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                currentPos.z = 0;
                path.SetPosition(path.positionCount - 1, currentPos);
                waypoint.setCol();
                Done = true;
            }
        }
    }
}
