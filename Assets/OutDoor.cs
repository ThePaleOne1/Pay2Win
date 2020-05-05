using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutDoor : MonoBehaviour
{
    [SerializeField] GameObject nextLevelStart;
    [SerializeField] GameObject interactPrompt;
    [SerializeField] GameObject TransitionEffect;
    // Start is called before the first frame update
    Animator tAnim;
    GameObject hitObj;
    bool isTriggered;

    [SerializeField] bool IsRealityDoor;
    private void Start()
    {
        tAnim = TransitionEffect.GetComponent<Animator>();
        TransitionEffect.SetActive(true);
    }

    private void Update()
    {
        if (GlobalVariables.isScreenBlack && isTriggered)
        {

            if (IsRealityDoor)
            {
                SceneManager.LoadScene("DesktopScene");
            }

            hitObj.transform.position = nextLevelStart.transform.position;
        }
        
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            isTriggered = true;
            interactPrompt.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                
                tAnim.SetTrigger("Transition");
            }
            hitObj = col.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            isTriggered = false;
            interactPrompt.SetActive(false);
        }
    }

}
