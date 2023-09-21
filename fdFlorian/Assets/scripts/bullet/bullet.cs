using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Transform target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            lookAtTarget(target);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void lookAtTarget(Transform target)
    {
        Vector3 vel = (target.position - transform.position);
        vel = vel.normalized;
        Vector2 direction = target.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
        transform.position += (vel * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
