﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once after every update
	void LateUpdate ()
    {
        transform.position = player.transform.position + offset;
    }
}
