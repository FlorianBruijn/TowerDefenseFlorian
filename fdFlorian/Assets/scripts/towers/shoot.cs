using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public float firerate;
    [SerializeField] private bool reloading;
    [SerializeField] private float bulletSpeed;
    public float damage;
    public GameObject bullet;
    public void shootProjectile(Transform target)
    {
        if (!reloading)
        {
            GameObject Bullet = Instantiate(bullet);
            bullet script = Bullet.GetComponent<bullet>();
            script.target = target;
            script.speed = bulletSpeed;
            script.damage = damage;
            Bullet.transform.position = transform.position;
            reloading = true;
            StartCoroutine(reload());
        }
    }
    private IEnumerator reload()
    {
        yield return new WaitForSeconds(1 / firerate);
        reloading = false;
    }
}
