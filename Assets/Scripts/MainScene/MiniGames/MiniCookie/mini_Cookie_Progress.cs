using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mini_Cookie_Progress : MonoBehaviour {


    public GameObject timerDisplay;

    public float timeLeft = 15.0f;
	
	void Update ()
    {

        if (timeLeft < 0.01f)
        {
            MasterScript.currencyCount += 25;
            SceneManager.LoadScene("MainScene");
        }

        timerDisplay.GetComponent<Text>().text = timeLeft.ToString("#.00");
    }

    public void Countdown()
    {
        timeLeft -= Time.deltaTime;

    }
}
