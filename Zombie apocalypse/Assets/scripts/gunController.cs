using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunController : MonoBehaviour
{
    public bool isFiring;

    public bulletController bullet;
    public float bulletSpeed;

    public float timeBeetwenShots;
    private float shotCounter;

    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter<=0)
            {
                shotCounter = timeBeetwenShots;
               bulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as bulletController;
                newBullet.speed = bulletSpeed;
            }
        }
        else 
        {
            shotCounter = 0;
        }

    }
}
