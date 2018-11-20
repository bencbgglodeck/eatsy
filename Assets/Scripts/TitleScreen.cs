using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {

    public GameObject dataPrefab;

    void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            dataPrefab.GetComponent<GameController>().Load();
            SceneManager.LoadScene("MainScene");
        }
	}
}
