using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchShop : MonoBehaviour
{
    [SerializeField] GameObject mainHUD;
    [SerializeField] GameObject shopScreen;
    GameObject activeHUD;

    //switch active canvas on button press
    public void switchShop()
    {
        if (GameObject.FindGameObjectWithTag("Shop") == null)
        {
            activeHUD = GameObject.FindGameObjectWithTag("MainHUD");
            Instantiate(shopScreen);
            Destroy(activeHUD);
        }
        if (GameObject.FindGameObjectWithTag("MainHUD") == null)
        {
            activeHUD = GameObject.FindGameObjectWithTag("Shop");
            Instantiate(mainHUD);
            Destroy(activeHUD);
        }
        
    }
}
