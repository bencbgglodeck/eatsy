using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameButton : MonoBehaviour {

    private void OnMouseDown()
    {
        if(MasterScript.energyCount > 0)
        {
            MasterScript.energyCount = MasterScript.energyCount - 1;
            SceneManager.LoadScene(gameObject.name);
        }
        else
        {
            Debug.Log("no energy");
        }

    }
}
