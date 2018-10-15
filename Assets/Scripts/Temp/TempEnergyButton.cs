using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempEnergyButton : MonoBehaviour {

    public GameObject energyButton;

    public void ClickTheButton()
    {
        MasterScript.energyCount += 1;
    }
}
