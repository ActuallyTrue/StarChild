﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazyStarChild : MonoBehaviour
{

    public float fireRate;
    private float fireTimer;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
        fireTimer = fireRate;
    }

    // Update is called once per frame
    void Update()
    {
        Aim(Player);
        fireTimer -= Time.deltaTime;
        if(fireTimer <= 0)
        {
            Shoot();
            fireTimer = fireRate;
        }
    }


    public void Aim(GameObject Player)
    {
        Vector3 targetDir = transform.position - Player.transform.position;
        float zAngle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 180f;
        transform.rotation = Quaternion.Euler(0, 0, zAngle);
    }

    public void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}