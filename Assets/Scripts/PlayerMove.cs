using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed, jumpForce;
    public Rigidbody2D rigidbody;
    public bool isGrounded;
    public LayerMask Foreground;
    public SpriteRenderer playerSprite;
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
        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.5f, transform.position.y - 0.5f), new Vector2(transform.position.x + 0.5f, transform.position.y + 0.5f), Foreground);

        vx = Input.GetAxisRaw("Horizontal");
        vy = rigidbody.velocity.y;
    }

    void FixedUpdate()
    {
        /*float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rigidbody.AddForce(movement * runSpeed);*/

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

        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.velocity = new Vector2(runSpeed, rigidbody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rigidbody.velocity = new Vector2(runSpeed * -1, rigidbody.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpForce);
        }
    }
}
