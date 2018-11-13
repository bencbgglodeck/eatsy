using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempShopScript : MonoBehaviour
{
    public void PurchaseItem1()
    {
        if (MasterScript.shopItemList[0] == 1)
        {
            MasterScript.playerColor = Color.red;
            Debug.Log("Already Purchased");
        }
        else if (MasterScript.currencyCount >= 5 && MasterScript.shopItemList[0] == 0)
        {
            MasterScript.playerColor = Color.red;
            MasterScript.shopItemList[0] = 1;
            MasterScript.currencyCount -= 5;
        }
    }

    public void PurchaseItem2()
    {
        if (MasterScript.shopItemList[1] == 1)
        {
            MasterScript.playerColor = Color.green;
            Debug.Log("Already Purchased");
        }
        else if (MasterScript.currencyCount >= 5 && MasterScript.shopItemList[1] == 0)
        {
            MasterScript.playerColor = Color.green;
            MasterScript.shopItemList[1] = 1;
            MasterScript.currencyCount -= 5;
        }
    }

    public void PurchaseItem3()
    {
        if (MasterScript.shopItemList[2] == 1)
        {
            MasterScript.shopItemList[2] = 1;
            Debug.Log("Already Purchased");
        }
        else if (MasterScript.currencyCount >= 5 && MasterScript.shopItemList[2] == 0)
        {
            MasterScript.playerColor = Color.magenta;
            MasterScript.shopItemList[2] = 1;
            MasterScript.currencyCount -= 5;
        }
    }

    public void PurchaseItem4()
    {
        if (MasterScript.shopItemList[3] == 1)
        {
            MasterScript.shopItemList[3] = 1;
            Debug.Log("Already Purchased");
        }
        else if (MasterScript.currencyCount >= 5 && MasterScript.shopItemList[3] == 0)
        {
            MasterScript.shopItemList[3] = 1;
            MasterScript.currencyCount -= 5;
        }
    }
}
