using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorchangeTEST : MonoBehaviour
{
    public Color[] colorBank;
    private SpriteRenderer s;

    void Start ()
    {
        s = GetComponent<SpriteRenderer>();
        int num = Random.Range(0, colorBank.Length);
        s.color = colorBank[num];
	}

    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int num = Random.Range(0, colorBank.Length);
            s.color = colorBank[num];
        }
    }
}
