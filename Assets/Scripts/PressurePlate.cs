using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField]
    GameObject[] triggerables;

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        anim.SetBool("IsSteppedOn", true);
        foreach (GameObject obj in triggerables)
        {

            obj.GetComponent<Trigerable>().IsTriggered = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("IsSteppedOn",false);
        foreach (GameObject obj in triggerables)
        {
            obj.GetComponent<Trigerable>().IsTriggered = false;
        }
    }
}
