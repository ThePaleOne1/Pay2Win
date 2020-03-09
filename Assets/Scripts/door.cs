using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    Animator anim;
    Trigerable trig;

    [SerializeField]
    bool Inverted = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        trig = GetComponent<Trigerable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Inverted)
        {
            if (trig.IsTriggered)
            {
                anim.SetBool("IsOpen", true);
            }
            else
            {
                anim.SetBool("IsOpen", false);
            }
        }
        else
        {
            if (trig.IsTriggered)
            {
                anim.SetBool("IsOpen", false);
            }
            else
            {
                anim.SetBool("IsOpen", true);
            }
        }
    }
}
