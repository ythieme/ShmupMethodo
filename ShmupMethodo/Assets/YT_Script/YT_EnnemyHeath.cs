﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YT_EnnemyHeath : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {


        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}