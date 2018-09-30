using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGenButton : MonoBehaviour {

    public GameObject textBox;

    public void ClickTheButton()
    {
        CurrencyTest.CurrencyCount += 1;
    }


}
