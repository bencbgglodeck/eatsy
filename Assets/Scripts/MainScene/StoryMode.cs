using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryMode : MonoBehaviour {

    private void OnMouseDown()
    {
        SceneManager.LoadScene("ComicTest");
        //if(MasterScript.storyLevel == 0 && MasterScript.energyCount > 0)
        //{
        //    MasterScript.energyCount--;
        //    SceneManager.LoadScene("ComicTest");
        //    SceneManager.LoadScene("MiniBlocks");
        //}

        //else if(MasterScript.storyLevel == 1 && MasterScript.energyCount > 0)
        //{
        //    MasterScript.energyCount--;
        //    SceneManager.LoadScene("MiniCat");
        //}

    }
}
