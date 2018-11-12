using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour {

    public ActorData data = new ActorData();

    public void Start()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Actor");
        if (obj.Length > 1)
        {
            Destroy(this.gameObject);
        }
    }

    public void StoreData()
    {
        data.currencyC = MasterScript.currencyCount;
        data.energyC = MasterScript.energyCount;
    }

    public void LoadData()
    {
        MasterScript.currencyCount = data.currencyC;
        MasterScript.energyCount = data.energyC;
    }

    public void ApplyData()
    {
        SaveData.AddActorData(data);
    }

    void OnEnable()
    {
        SaveData.OnLoaded += LoadData;
        SaveData.OnBeforeSave += StoreData;
        SaveData.OnBeforeSave += ApplyData;
    }

    void OnDisable()
    {
        SaveData.OnLoaded -= LoadData;
        SaveData.OnBeforeSave -= StoreData;
        SaveData.OnBeforeSave -= ApplyData;
    }
}

[Serializable]
public class ActorData
{
    public int currencyC;

    public int energyC;

    public Vector3 pos;
}
