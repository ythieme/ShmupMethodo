using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private float TimerDestroy;

    [SerializeField]
    float TimeToDestroy = 100f;

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("BONJOUR");
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
    
    void Update()
    {
        TimerDestroy += Time.deltaTime;
        if (TimerDestroy > TimeToDestroy)
        {
            Destroy(this.gameObject);
        }
    }
}
