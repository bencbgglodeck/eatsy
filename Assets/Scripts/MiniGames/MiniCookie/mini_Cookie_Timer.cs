using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mini_Cookie_Timer : MonoBehaviour {

    public float colorTimer;
    public static bool ready;

    public GameObject colorBar;
    private SpriteRenderer spriteR;
    public Sprite[] spriteList;
    public GameObject speakEffect;
    public Vector3 speakLocation;

    void Start () {

        colorTimer =  Random.Range(1.0f, 4f);
        spriteR = gameObject.GetComponent<SpriteRenderer>();

        StartCoroutine(Cooldown(colorTimer));
	}

    void SetActive()
    {
        StartCoroutine(SpawnerEnable(0.1f));
        ready = true;
        spriteR.sprite = spriteList[1];
        colorTimer = Random.Range(1f, 4f);
        StartCoroutine(Duration(colorTimer));
    }

    void SetInactive()
    {
        StartCoroutine(SpawnerDisable());
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

    private IEnumerator SpawnerEnable(float timer)
    {
        yield return new WaitForSeconds(timer);
        Instantiate(speakEffect, speakLocation, Quaternion.identity);

        yield return null;
    }

    private IEnumerator SpawnerDisable()
    {
        Destroy(GameObject.FindWithTag("Destroy"));
        yield return null;
    }
}
