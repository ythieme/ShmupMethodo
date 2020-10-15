using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YT_EnnemyHealth : MonoBehaviour
{
    public int EnnemyLife = 100;
    public Animator ennemyAnim;
    public YT_EnnemiShoot ennemyShoot;

    private void GetDamage(int damage)
    {
        EnnemyLife -= damage;
        print(EnnemyLife);

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("PlayerAttack"))
        {
            GetDamage(col.gameObject.GetComponent<YT_Damager>().Damage());
        }
    }

    private void GetDeath()
    {
        ennemyAnim.SetBool("Explosion", true);
        if (ennemyShoot.IsAlive == true)
        {
            ennemyShoot.IsAlive = false;
        }

        else if (ennemyShoot.IsAlive == false)
        {
            ennemyShoot.IsAlive = false;
        }
    }

    private void Update()
    {
        if (EnnemyLife <= 0)
        {
            GetDeath();
        }
    }

}
