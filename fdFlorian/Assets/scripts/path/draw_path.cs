using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draw_path : MonoBehaviour
{
    private LineRenderer path;
    private Vector3 previouspos;

    [SerializeField] private Transform start;
    [SerializeField] private Transform finish;

    public bool canStart;
    public bool drawing;
    public bool canFinish;

    [SerializeField] private float minDist = 1f;
    void Start()
    {
        path = GetComponent<LineRenderer>();
        previouspos = transform.position;
    }

    void Update()
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
                }
                else
                {
                    path.positionCount++;
                    path.SetPosition(path.positionCount - 1, Currentpos);
                }
                previouspos = Currentpos;
            }
        }
    }
}
