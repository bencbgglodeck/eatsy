using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyDisplayerVictory : MonoBehaviour
{
    public GameObject CurrencyDisplay;
    private int internalCurrency;

    void Update()
    {
        internalCurrency = MasterScript.currencyCount;
        CurrencyDisplay.GetComponent<Text>().text = "You now have " + internalCurrency + " cash!";
    }
}
