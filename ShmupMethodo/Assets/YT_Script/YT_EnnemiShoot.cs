using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YT_EnnemiShoot : MonoBehaviour
{

    public float bulletForce;

    //Intervalle de tir
    delegate void shootFunc();
    shootFunc Shoot;

    [Range(0, 5)]
    public float shootIntervale;

    Vector2 pcPos;
    Vector2 pCDirection;
    public GameObject bulletPrefab;
    public Transform firePoint;
    public Transform perso;

    private void Start()
    {
        Shoot = DoShoot;
    }

    void Update()
    {
        Shoot();
    }
    private void DoShoot()
    {
        StopCoroutine(nameof(ShootInvervalle));

        pCDirection = (perso.transform.position - transform.position).normalized * bulletForce;
        GameObject fireBullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        fireBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(pCDirection.x, pCDirection.y);

        Shoot = dontShoot;

    }

    void dontShoot()
    {
        StartCoroutine(nameof(ShootInvervalle));
    }

    IEnumerator ShootInvervalle()
    {
        yield return new WaitForSeconds(shootIntervale);
        Shoot = DoShoot;
    }
}