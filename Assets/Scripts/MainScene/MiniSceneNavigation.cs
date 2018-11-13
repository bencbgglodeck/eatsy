using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniSceneNavigation : MonoBehaviour
{
    public void CatGameEnter()
    {
        if (MasterScript.energyCount > 0)
        {
            MasterScript.energyCount--;
            SceneManager.LoadScene("MiniCat");
        }
    }
    public void FoodGameEnter()
    {
        if (MasterScript.energyCount > 0)
        {
            MasterScript.energyCount--;
            SceneManager.LoadScene("MiniFood");
        }
    }
    public void CookieGameEnter()
    {
        if (MasterScript.energyCount > 0)
        {
            MasterScript.energyCount--;
            SceneManager.LoadScene("MiniCookie");
        }
    }
    public void BlockGameEnter()
    {
        if (MasterScript.energyCount > 0)
        {
            MasterScript.energyCount--;
            SceneManager.LoadScene("MiniBlocks");
        }
    }
    public void BackEnter()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void ShopEnter()
    {
        SceneManager.LoadScene("ShopScene");
    }
}