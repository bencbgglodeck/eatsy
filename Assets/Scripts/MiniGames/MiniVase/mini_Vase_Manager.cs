using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mini_Vase_Manager : MonoBehaviour {

    public GameObject prefab;
    public Transform[] spawnPoints;

    public float spawnTime = 0.3f;

    void Start()
    {

        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(prefab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
