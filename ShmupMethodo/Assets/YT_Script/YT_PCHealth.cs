using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YT_PCHealth : MonoBehaviour
{
    YT_PlayerController controller;
    //Variable Life
    public int PlayerLife = 100;

    //public GameObject MenuPause;
    private void GetDamage(int damage)
    {
        PlayerLife -= damage;
        print(PlayerLife);

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("EnnemyAttack") ^ col.gameObject.CompareTag("Ennemies"))
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
        if (PlayerLife <= 0)
        {
            GetDeath();
        }
    }
}