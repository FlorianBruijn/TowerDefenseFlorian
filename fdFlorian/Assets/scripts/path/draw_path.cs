using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draw_path : MonoBehaviour
{
    private LineRenderer path;
    private Vector3 previouspos;

    [SerializeField] private float minDist = 1f;
    void Start()
    {
        path = GetComponent<LineRenderer>();
        previouspos = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 Currentpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Currentpos.z = 0;

            if(Vector3.Distance(Currentpos, previouspos) > minDist)
            {
                path.positionCount++;
                path.SetPosition(path.positionCount - 1, Currentpos);
                previouspos = Currentpos;
            }
        }
    }
}
