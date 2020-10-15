using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YT_EnnemyHealth : MonoBehaviour
{
    public int EnnemyLife = 100;

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
        Destroy(gameObject);
    }

    private void Update()
    {
        if (EnnemyLife <= 0)
        {
            GetDeath();
        }
    }

}
