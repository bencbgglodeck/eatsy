using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mini_Cookie_Button : MonoBehaviour {

    public mini_Cookie_Progress prog;
    public mini_Cookie_Timer time;


    public void OnMouseDrag()
    {
        if (time.ready == false)
        {
            SceneManager.LoadScene("LoseScene");

        }
        else if (time.ready == true)
        {
            prog.Countdown();
        }
    }
}

