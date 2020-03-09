using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField]
    GameObject[] triggerables;
    [SerializeField]
    GameObject ePrompt;

    Animator anim;

    bool isOn = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn)
        {
            anim.SetBool("isOn", true);
            foreach (GameObject obj in triggerables)
            {
                obj.GetComponent<Trigerable>().IsTriggered = true;
            }
        }
        else
        {
            anim.SetBool("isOn", false);
            foreach (GameObject obj in triggerables)
            {
                obj.GetComponent<Trigerable>().IsTriggered = false;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isOn = !isOn;
            }
            ePrompt.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ePrompt.SetActive(false);
        }
    }
}
