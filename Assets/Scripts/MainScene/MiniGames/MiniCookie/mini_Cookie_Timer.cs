using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mini_Cookie_Timer : MonoBehaviour {

    public float colorTimer;
    public bool ready;

    public GameObject colorBar;
    public SpriteRenderer spriteR;

    void Start () {

        colorTimer =  Random.Range(3.0f, 10.0f);
        spriteR = gameObject.GetComponent<SpriteRenderer>();

        StartCoroutine(Cooldown(colorTimer));
	}

    void SetActive()
    {
        ready = true;
        spriteR.color = Color.green;
        colorTimer = Random.Range(3.0f, 10.0f);
        StartCoroutine(Duration(colorTimer));
    }

    void SetInactive()
    {
        ready = false;
        colorTimer = Random.Range(3.0f, 10.0f);
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
        spriteR.color = Color.red;

        yield return new WaitForSeconds(0.3f);

        SetInactive();
        yield return null;
    }


}
