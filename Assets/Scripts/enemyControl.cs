using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class enemyControl : MonoBehaviour
{

    public GameObject firePos;
    public GameObject bulletPrefab;
    GameObject player;
    public float fireInterval = 3f;
    float timer = 0f;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= fireInterval)
        {
            FireBullet();
            timer = 0f;
        }
    }

    void FireBullet()
    {
        Vector3 direction = (player.transform.position - firePos.transform.position).normalized;
        Instantiate(bulletPrefab, firePos.transform.position, Quaternion.LookRotation(direction));
    }
}
