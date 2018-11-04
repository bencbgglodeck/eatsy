using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceNavigation : MonoBehaviour
{
    public GameObject interfaceBar;
    public GameObject interfaceArrow;

    public void MiniGameEnter()
    {
        SceneManager.LoadScene("MiniScene");
    }
    public void ShopEnter()
    {
        SceneManager.LoadScene("ShopScene");
    }
    public void SettingsEnter()
    {
        SceneManager.LoadScene("SettingScene");
    }
    public void ArrowUp()
    {
        interfaceBar.SetActive(true);
        interfaceArrow.SetActive(false);
    }
    public void ArrowDown()
    {
        interfaceBar.SetActive(false);
        interfaceArrow.SetActive(true);
    }

}
