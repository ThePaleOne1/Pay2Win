using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    [SerializeField]
    PlayerController pc;

    private void OnTriggerStay2D(Collider2D collision)
    {
        //ground detect
        if (collision.gameObject.layer == 8)
        {
            pc.isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //ground detect
        if (collision.gameObject.layer == 8)
        {
            pc.isGrounded = false;
        }
    }
}
