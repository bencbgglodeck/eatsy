﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameButton : MonoBehaviour {

    private void OnMouseDown()
    {
        SceneManager.LoadScene("TestGame");
    }
}
