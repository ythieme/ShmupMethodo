using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YT_BulletDestroyEnnemy : MonoBehaviour
{
    private float TimerDestroy;

    [SerializeField]
    float TimeToDestroy = 100f;


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {

        TimerDestroy += Time.deltaTime;
        if (TimerDestroy > TimeToDestroy)
        {
            Destroy(gameObject);
        }
    }

}
