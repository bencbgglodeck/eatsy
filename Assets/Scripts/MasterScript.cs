using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterScript : MonoBehaviour
{
    public static int currencyCount;
    public static int energyCount;
    public static int blockCounter = 0;
    public static int spiceCounter = 0;
    public static int catLives = 3;
    public static int[] shopItemList = new int[4];
    public static Color playerColor = Color.white;
    public static bool musicController = true;

    private void Start()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Master");
        if(obj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

}
