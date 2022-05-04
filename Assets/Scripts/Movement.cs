using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    private Vector3 position;
    private bool positionChanged = false;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;

    private Rigidbody2D body;
    private BoxCollider2D BoxCollider;
    private float wallJumpCooldown;

    internal void moveToNexDoor(Transform nextDoor)
    {
        Debug.Log("key pressed CCC");
        positionChanged = true;
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
        //if(positionChanged)
        //{
         //   transform.position = position;
          //  positionChanged = false;
        //}


        horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        if (horizontalInput > 0.1f)     
        {
            transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        }else if (horizontalInput < -0.1f)
        {
            transform.localScale = new Vector3(-0.7f, 0.7f, 0.7f);
        }

        
        if (wallJumpCooldown < 0.2f)
        {
            
            body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);
            if(onWall() && !isGrounded())
            {
                body.gravityScale = 0;
                body.velocity = Vector2.zero;
            }
            else
            {
                body.gravityScale = 3;
            }

            if (Input.GetKey(KeyCode.Space))
            {
                Jump();
            }

        }
        else
        {
            wallJumpCooldown += Time.deltaTime;
        }

    }

    private void Jump()
    {
        if (isGrounded())
        {
            body.velocity = new Vector2(body.velocity.x, speed);

        }
        else if (onWall() && !isGrounded())
        {
            if (horizontalInput == 0)
            {
                body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 10, 0);
                transform.localScale = new Vector3(-Mathf.Sign(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }
            else
            {
                body.velocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 3, 6);
            }
            wallJumpCooldown = 0;

        }
    }

    private bool isGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(BoxCollider.bounds.center, BoxCollider.bounds.size, 0, Vector2.down,0.1f,groundLayer) ;

        return raycastHit2D.collider != null;
    }

    private bool onWall()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(BoxCollider.bounds.center, BoxCollider.bounds.size, 0, new Vector2(transform.localScale.x,0), 0.1f, wallLayer);

        return raycastHit2D.collider != null;
    }
}
