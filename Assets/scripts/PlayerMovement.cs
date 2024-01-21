using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0f;

    private float horizinput;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizinput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizinput * speed, rb.velocity.y);
    }
}
