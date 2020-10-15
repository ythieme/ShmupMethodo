using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YT_Bullets : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    delegate void shootFunc();
    shootFunc Shoot;

    public float bulletForce = 20f;

    [Range(0, 5)]
    public float shootIntervale;
    // Start is called before the first frame update
    void Start()
    {
        Shoot = DoShoot;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

    void DoShoot()
    {
        StopCoroutine(nameof(ShootInvervalle));

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = firePoint.right * bulletForce;

        Shoot = DontShoot;

    }
    void DontShoot()
    {
        StartCoroutine(nameof(ShootInvervalle));
    }

    IEnumerator ShootInvervalle()
    {
        yield return new WaitForSeconds(shootIntervale);
        Shoot = DoShoot;
    }
}
