using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComicTest : MonoBehaviour
{
    public GameObject[] comicArray;
    private int comicCounter = 0;
    private int comicLength;

    private void Start()
    {
        comicLength = comicArray.Length;
    }
    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(comicLength);
            Debug.Log(comicCounter);
            if (comicCounter >= comicLength)
            {
                //Might Remove
                MasterScript.comicCount++;
                if(MasterScript.storyLevel == 0 && MasterScript.energyCount > 0)
                {
                    MasterScript.energyCount--;
                    SceneManager.LoadScene("MiniBlocks");
                }

                else if(MasterScript.storyLevel == 1 && MasterScript.energyCount > 0)
                {
                    MasterScript.energyCount--;
                    SceneManager.LoadScene("MiniCat");
                }
            }
            else
            {
                comicArray[comicCounter].SetActive(true);
                comicCounter++;
            } 
        }
    }
}
