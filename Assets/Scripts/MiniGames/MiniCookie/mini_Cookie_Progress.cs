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

        timerDisplay.GetComponent<Text>().text = timeLeft.ToString();

        if (timeLeft < 0.0f)
        {
            MasterScript.currencyCount += 25;
            SceneManager.LoadScene("MainScene");
        }
	}

    public void Countdown()
    {

        timeLeft -= Time.deltaTime;

    }
}
