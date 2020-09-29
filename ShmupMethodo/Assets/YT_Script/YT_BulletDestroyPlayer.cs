using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YT_BulletDestroyPlayer : MonoBehaviour
{
    private float TimerDestroy;

    [SerializeField]
    float TimeToDestroy = 100f;


    void OnCollisionEnter2D(Collision2D col)
    {


        if (col.gameObject.CompareTag("Ennemies"))
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
