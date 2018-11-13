using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mini_Cookie_Timer : MonoBehaviour {

    public float colorTimer;
    public bool ready;

    public GameObject colorBar;
    private SpriteRenderer spriteR;
    public Sprite[] spriteList;

    void Start () {

        colorTimer =  Random.Range(1.0f, 4f);
        spriteR = gameObject.GetComponent<SpriteRenderer>();

        StartCoroutine(Cooldown(colorTimer));
	}

    void SetActive()
    {
        ready = true;
        spriteR.sprite = spriteList[1];
        colorTimer = Random.Range(1f, 4f);
        StartCoroutine(Duration(colorTimer));
    }

    void SetInactive()
    {
        ready = false;
        colorTimer = Random.Range(1f, 4f);
        StartCoroutine(Cooldown(colorTimer));
    }

    private IEnumerator Cooldown(float timer)
    {

        yield return new WaitForSeconds(timer);

        SetActive();
        yield return null;
    }

    private IEnumerator Duration(float timer)
    {

        yield return new WaitForSeconds(timer);

        Debug.Log("time frame over");
        spriteR.sprite = spriteList[0];

        yield return new WaitForSeconds(0.3f);

        SetInactive();
        yield return null;
    }


}
