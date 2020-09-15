using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YT_PlayerController : MonoBehaviour
{
    public float movespeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);


    }
}
