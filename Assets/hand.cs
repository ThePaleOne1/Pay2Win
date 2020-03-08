using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour
{
    bool isHolding = false;
    
    GameObject heldObj;
    [SerializeField]

    GameObject player;
    float handXOffset;


    // Start is called before the first frame update
    void Start()
    {
        handXOffset = transform.localPosition.x;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (player.GetComponent<SpriteRenderer>().flipX)
        {
            transform.localPosition = new Vector2(-handXOffset , transform.localPosition.y);

            if (Input.GetKeyDown(KeyCode.E) && isHolding)
            {
                Drop(-0.2f);
            }
        }
        else
        {
            transform.localPosition = new Vector2(handXOffset, transform.localPosition.y);

            if (Input.GetKeyDown(KeyCode.E) && isHolding)
            {
                Drop(0.2f);
            }
        }
    }

   
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Pickup" && Input.GetKeyUp(KeyCode.E) && !isHolding && collision.gameObject != heldObj)
        {
            print("pickup obj");
            heldObj = collision.gameObject;
            heldObj.transform.SetParent(transform);
            heldObj.transform.localPosition = Vector2.zero;
            heldObj.GetComponent<Collider2D>().enabled = false;
            heldObj.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            heldObj.GetComponent<Rigidbody2D>().freezeRotation = true;
            isHolding = true;
        }
    }


    void Drop(float offset)
    {
        print("dropped");
        isHolding = false;
        heldObj.transform.localPosition = new Vector2(offset, 0.1f);
        heldObj.transform.parent = null;
        heldObj.GetComponent<Collider2D>().enabled = true;
        heldObj.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        heldObj.GetComponent<Rigidbody2D>().freezeRotation = false;
        Invoke("heldNull", 0.2f);
    }

    void heldNull()
    {
        heldObj = null;
    }
}
