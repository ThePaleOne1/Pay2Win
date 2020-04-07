using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCount : MonoBehaviour
{
    public float moneyCount = 10;

    [SerializeField]
    Text moneyText;
    public float moneySpent = 0;

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "Bank: $" + moneyCount;
    }
}
