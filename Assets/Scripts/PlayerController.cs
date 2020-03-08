using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float Speed = 1f;
    [SerializeField]
    float jumpForce = 1f;

    Animator anim;
    Rigidbody2D rb;

    public bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //stop character from sliding after letting go of A/D
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            anim.SetBool("IsWalking", false);
        }

        //walk left
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("IsWalking", true);
            rb.velocity = new Vector2(-Speed, rb.velocity.y);
            GetComponent<SpriteRenderer>().flipX = true;
        }

        //walk right
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("IsWalking", true);
            rb.velocity = new Vector2(Speed, rb.velocity.y);
            GetComponent<SpriteRenderer>().flipX = false;
        }

        //jump
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space)) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }

        //couch
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("IsCrouching", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("IsCrouching", false);
        }

        //grounded
        if (isGrounded)
        {
            anim.SetBool("IsGrounded", true);
        }
        else
        {
            anim.SetBool("IsGrounded", false);
        }

    }

    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    //ground detect
    //    if (collision.gameObject.layer == 8)
    //    {
    //        anim.SetBool("IsGrounded", true);
    //    }
    //}
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    //ground detect
    //    if (collision.gameObject.layer == 8)
    //    {
    //        anim.SetBool("IsGrounded", false);
    //    }
    //}
}
