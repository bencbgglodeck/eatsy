using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyTest : MonoBehaviour {

    public static int CurrencyCount;
    public GameObject CurrencyDisplay;
    public int InternalCurrency;
	
	void Update () {

        InternalCurrency = CurrencyCount;
        CurrencyDisplay.GetComponent<Text>().text = "Currency: " + InternalCurrency;

	}
}
