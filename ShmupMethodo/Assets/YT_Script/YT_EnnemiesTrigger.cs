using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YT_EnnemiesTrigger : MonoBehaviour
{
    public GameObject Ennemies;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Ennemies.SetActive(true);
        }
    }
}
