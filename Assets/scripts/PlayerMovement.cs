using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0f;
    public float JumpHeight = 0f;

    private float horizinput;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizinput = Input.GetAxisRaw("Horizontal");
        if(Input.GetKeyDown(KeyCode.Space) )
        {
            rb.velocity = Vector2.up * JumpHeight;
        }
    } 

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizinput * speed, rb.velocity.y);
    }
}
