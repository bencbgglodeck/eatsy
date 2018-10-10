using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mini_Cookie_Progress : MonoBehaviour {


    public GameObject timerDisplay;

    public float timeLeft = 60.0f;
	
	void Update ()
    {

        timerDisplay.GetComponent<Text>().text = timeLeft.ToString();
	}

    public void Countdown()
    {

        timeLeft -= Time.deltaTime;

    }
}
