using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YT_EnnemiShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    private float TimerShoot;

    [SerializeField]
    float TimeToShoot = 0.5f;

    void Update()
    {
        TimerShoot += Time.deltaTime;

        if (TimerShoot > TimeToShoot)
        {
            TimerShoot = 0f;
            Shoot(); TimerShoot = 0;
        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {


        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.transform.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }
}
