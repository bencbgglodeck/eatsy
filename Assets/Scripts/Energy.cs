using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour {

    public GameObject energyDisplay;
    private int internalEnergy;

    void Update()
    {
        internalEnergy = MasterScript.energyCount;
        energyDisplay.GetComponent<Text>().text = "Energy: " + internalEnergy;
    }
}
