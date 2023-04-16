using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public Transform ChargedbulletSpawnPoint;
    [SerializeField] private GameObject ChargedBullet;
    [SerializeField] private float chargeSpeed;
    [SerializeField] private float chargeTime;
    private bool isCharging;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && chargeTime < 2)
        {
            isCharging = true;
            if(isCharging == true)
            {
                chargeTime += Time.deltaTime * chargeSpeed;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            chargeTime = 0;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && chargeTime >= 2)
        {
            ReleaseCharge();
        }
    }

    void ReleaseCharge()
    {
        Instantiate(ChargedBullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        isCharging = false;
        chargeTime = 0;
    }
}