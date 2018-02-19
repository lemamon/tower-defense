using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {
    public GameObject bulletPrefab;
    private float timeShoot = 1f;
    private float lastShootTime;

	void Update ()
    {
        Shoot();
    }

    private void Shoot()
    {
        float currentTime = Time.time;
        if(currentTime > lastShootTime + timeShoot)
        {
            lastShootTime = currentTime;
            Vector3 shootPoint = this.transform.Find("TowerGun/ShootPoint").gameObject.transform.position;
            Instantiate(bulletPrefab, shootPoint, Quaternion.identity);
        }
      
    }
}
