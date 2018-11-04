using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempShopScript : MonoBehaviour
{
    public void ClickTheButton()
    {
        MasterScript.currencyCount -= 5;
        if (MasterScript.currencyCount < 0)
        {
            MasterScript.currencyCount = 0;
        }
    }
}
