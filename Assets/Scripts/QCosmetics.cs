using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QCosmetics : MonoBehaviour
{
    private SpriteRenderer sr;
	void Start ()
    {
	    sr = gameObject.GetComponent<SpriteRenderer>();
        sr.color = MasterScript.playerColor;
    }
}
