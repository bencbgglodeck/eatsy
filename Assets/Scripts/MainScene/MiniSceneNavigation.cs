using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniSceneNavigation : MonoBehaviour
{
    public void CatGameEnter()
    {
        SceneManager.LoadScene("MiniCat");
    }
    public void FoodGameEnter()
    {
        SceneManager.LoadScene("MiniFood");
    }
    public void CookieGameEnter()
    {
        SceneManager.LoadScene("MiniCookie");
    }
    public void BlockGameEnter()
    {
        SceneManager.LoadScene("MiniBlocks");
    }
    public void BackEnter()
    {
        SceneManager.LoadScene("MainScene");
    }
}
