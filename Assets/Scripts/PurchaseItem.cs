using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseItem : MonoBehaviour
{
    [SerializeField]
    GameObject ItemPrefab;
    [SerializeField]
    float cost = 1;
    [SerializeField]
    GameObject player;
    MoneyCount mc;
    // Start is called before the first frame update
    void Start()
    {
        mc = player.GetComponent<MoneyCount>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void purchaseItem()
    {
        if (mc.moneyCount >= cost) 
        {
            mc.moneyCount -= cost;
            Instantiate(ItemPrefab, player.transform.position + new Vector3(Random.Range(-1, 1), Random.Range(0, 1), 0), player.transform.rotation);
        }
    }
}
