using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;
    private Vector3 position;

    private Rigidbody2D body;
    private BoxCollider2D BoxCollider;

    internal void moveToNexDoor(Transform nextDoor)
    {
        transform.position = nextDoor.position;
    }

    private float horizontalInput;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        BoxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        if (horizontalInput > 0.1f)     
        {
            transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        }else if (horizontalInput < -0.1f)
        {
            transform.localScale = new Vector3(-0.7f, 0.7f, 0.7f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }

    }

    private void Jump()
    {
        if (isGrounded())
        {
            body.velocity = new Vector2(body.velocity.x, speed);

        }
    }

    private bool isGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(BoxCollider.bounds.center, BoxCollider.bounds.size, 0, Vector2.down,0.1f,groundLayer) ;

        return raycastHit2D.collider != null;
    }

}
