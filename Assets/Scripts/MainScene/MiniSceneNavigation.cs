using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniSceneNavigation : MonoBehaviour
{
    public void CatGameEnter()
    {
        MasterScript.energyCount--;
        SceneManager.LoadScene("MiniCat");
    }
    public void FoodGameEnter()
    {
        MasterScript.energyCount--;
        SceneManager.LoadScene("MiniFood");
    }
    public void CookieGameEnter()
    {
        MasterScript.energyCount--;
        SceneManager.LoadScene("MiniCookie");
    }
    public void BlockGameEnter()
    {
        MasterScript.energyCount--;
        SceneManager.LoadScene("MiniBlocks");
    }
    public void BackEnter()
    {
        MasterScript.energyCount--;
        SceneManager.LoadScene("MainScene");
    }
}
