﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_movement : MonoBehaviour
{
    public float runSpeed;
    public float jumpForce;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRend;
    public bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        spriteRend = gameObject.GetComponent<SpriteRenderer>();



    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontal * runSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }

}
