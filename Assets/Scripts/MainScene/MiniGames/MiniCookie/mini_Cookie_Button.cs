using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mini_Cookie_Button : MonoBehaviour {

    public mini_Cookie_Progress prog;
    public GameObject cookieEffect;
    public bool effectReady = true;


    public void OnMouseDrag()
    {
        if (mini_Cookie_Timer.ready == false)
        {
            //Debug.Log("testloss");
            SceneManager.LoadScene("LoseScene");
        }
        else if (mini_Cookie_Timer.ready == true)
        {
            if (effectReady == true)
            {
                Instantiate(cookieEffect, Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
                effectReady = false;
            }
            prog.Countdown();
        }
    }
 
    public void OnMouseUpAsButton()
    {
        effectReady = true;
    }
}
