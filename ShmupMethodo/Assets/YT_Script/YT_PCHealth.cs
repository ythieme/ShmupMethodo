using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YT_PCHealth : MonoBehaviour
{
    YT_PlayerController controller;
    //Variable Life
    public int PlayerLife = 100;

    public Slider slider;

    //public GameObject MenuPause;
    private void GetDamage(int damage)
    {
        PlayerLife -= damage;
        print(PlayerLife);
        SetHealth(PlayerLife);

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

    public void SetMaxHealth(int PlayerLife)
    {
        slider.maxValue = PlayerLife;
        slider.value = PlayerLife;
    }

    public void SetHealth(int PlayerLife)
    {
        slider.value = PlayerLife;
    }
}