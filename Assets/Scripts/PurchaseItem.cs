using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseItem : MonoBehaviour
{
    [SerializeField]
    GameObject itemPrefab;
    [SerializeField]
    float cost = 1;
    [SerializeField]
    GameObject player;
    MoneyCount mc;
    Text buttonText;

    // Start is called before the first frame update
    void Start()
    {
        mc = player.GetComponent<MoneyCount>();
        buttonText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(itemPrefab.name == "testCube")
        {
            buttonText.text = "Box: $" + cost;
        }
        else
        {
            buttonText.text = itemPrefab.name + ": " + cost;
        }
    }

    public void purchaseItem()
    {
        if (mc.moneyCount >= cost) 
        {
            mc.moneyCount -= cost;
            mc.moneySpent += cost;
            Instantiate(itemPrefab, player.transform.position + new Vector3(Random.Range(-1, 1), Random.Range(0, 1), 0), player.transform.rotation);
        }
    }
}
