using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletDamage;
    public float bulletSpeed;
    public float bulletLife;

    void Start()
    {
        Invoke("destroyBullet", bulletLife);
    }

    void Update()
    {
        transform.Translate(transform.right * bulletSpeed * Time.deltaTime);
    }

    void destroyBullet()
    {
        Destroy(this.gameObject);
    }
}
