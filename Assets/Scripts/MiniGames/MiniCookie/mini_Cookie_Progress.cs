using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mini_Cookie_Progress : MonoBehaviour {


    public GameObject timerDisplay;

    public float timeLeft = 15.0f;
    private float timeMax = 15;
    public GameObject Cookie;
    private Sprite cookieSprite;
    public Sprite[] cookieSprites;
    private int timeCount = 0;
    public AudioClip eatClip;

    void Update ()
    {
        float y = timeMax - timeLeft;
        int i = (int)y;
        Cookie.GetComponent<SpriteRenderer>().sprite = cookieSprites[i];
        if (i > timeCount)
        {
            gameObject.GetComponent<AudioSource>().clip = eatClip;
            gameObject.GetComponent<AudioSource>().pitch = (Random.Range(0.8f, 1.2f));
            gameObject.GetComponent<AudioSource>().Play();
            timeCount = i;
        }
         
        if (timeLeft < 0.01f)
        {
            MasterScript.currencyCount += 25;
            SceneManager.LoadScene("VictoryScene");
        }

        timerDisplay.GetComponent<Text>().text = timeLeft.ToString("#.00");
    }

    public void Countdown()
    {
        timeLeft -= Time.deltaTime;

    }
}
