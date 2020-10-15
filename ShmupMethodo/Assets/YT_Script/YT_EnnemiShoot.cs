using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YT_EnnemiShoot : MonoBehaviour
{

    public float bulletForce;

    //Intervalle de tir
    delegate void shootFunc();
    shootFunc Shoot;
    public bool IsAlive;

    [Range(0, 5)]
    public float shootIntervale;

    Vector2 pcPos;
    Vector2 pCDirection;
    public GameObject bulletPrefab;

    [SerializeField]
    public Transform[] firePoint;

    public int firepointIndex = 0;


    public Transform perso;

    private void Start()
    {
        Shoot = DoShoot;
        IsAlive = true;

    }

    void Update()
    {
        Shoot();
    }
    private void DoShoot()
    {
        if(IsAlive == true)
        {

            StopCoroutine(nameof(ShootInvervalle));

            pCDirection = (perso.transform.position - transform.position).normalized * bulletForce;

            for(int i = 0; i < firePoint.Length; i++)
            {
                GameObject fireBullet = Instantiate(bulletPrefab, firePoint[i].position, firePoint[i].rotation);
                 fireBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(pCDirection.x, pCDirection.y);
            }

            Shoot = dontShoot;

        }

        else if (IsAlive == false)
        {
            Shoot = StopShoot;
        }

    }

    void StopShoot()
    {
        StartCoroutine(nameof(Destrcution));
    }

    IEnumerator Destrcution()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
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