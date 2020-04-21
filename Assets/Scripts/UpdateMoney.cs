using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateMoney : MonoBehaviour
{
    GameObject player;
    MoneyCount mc;
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        mc = player.GetComponent<MoneyCount>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Bank: $" + mc.moneyCount;
    }
}
