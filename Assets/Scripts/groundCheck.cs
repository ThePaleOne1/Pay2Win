using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    [SerializeField]
    PlayerController pc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
