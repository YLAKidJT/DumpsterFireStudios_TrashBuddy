using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed, jumpForce;
    public Rigidbody2D rb;
    public bool isGrounded;
    public LayerMask Foreground;
    private float vx, vy;
    public bool facingRight;

    // Start is called before the first frame update
    void Start()
    {
        facingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        vx = Input.GetAxisRaw("Horizontal");
        vy = rb.velocity.y;
    }

    void FixedUpdate()
    {
        Vector3 localScale = transform.localScale;

        if (vx > 0)
        {
            facingRight = true;
        }
        else if (vx < 0)
        {
            facingRight = false;
        }

        if ((facingRight && (localScale.x < 0)) || (!facingRight && (localScale.x > 0)))
        {
            localScale.x *= -1;
        }

        transform.localScale = localScale;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(runSpeed, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(runSpeed * -1, rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 1.2f, transform.position.y - 1.2f), new Vector2(transform.position.x + 1.2f, transform.position.y + 1.2f), Foreground);
    }
}
