using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MiniFood : MonoBehaviour
{
    public int neededSpice;
    public static int usedSpice;
    public Text text;
    private int[] spiceCounter = new int[4];
        
	void Start ()
    {
        neededSpice = Random.Range(0, 3);
    }
	
	void Update ()
    {
        if (neededSpice == 0)
        {
            if (spiceCounter[neededSpice] == 0)
            {
                text.text = ("Give me the spice that is round.");
            }
            else if (spiceCounter[neededSpice] == 1)
            {
                text.text = ("Round one please.");
            }
            
        }
        else if (neededSpice == 1)
        {
            if (spiceCounter[neededSpice] == 0)
            {
                text.text = ("Give me the spice that has four corners and looks a bit like corn.");
            }
            else if (spiceCounter[neededSpice] == 1)
            {
                text.text = ("What spice do i need? hmmm... Well yes it is obvious the corn looking one again.");
            }
           
            
        }
        else if (neededSpice == 2)
        {
            if (spiceCounter[neededSpice] == 0)
            {
                text.text = ("Give me the pyramid looking spice.");
            }
            else if (spiceCounter[neededSpice] == 1)
            {
                text.text = ("The spice from egypt again please.");
            }     
        }
        else if (neededSpice == 3)
        {
            if (spiceCounter[neededSpice] == 0)
            {
                text.text = ("Give me the spice has four corners and is very basic.");
            }
            else if (spiceCounter[neededSpice] == 1)
            {
                text.text = ("Give me the basic one again.");
            }  
        }

        if (usedSpice == neededSpice)
        {
            spiceCounter[neededSpice]++;
            while (neededSpice == usedSpice)
            {
                neededSpice = Random.Range(0, 3);
            }
            MasterScript.spiceCounter++;
        }

        if (MasterScript.spiceCounter >= 4)
        {
            MasterScript.spiceCounter = 0;
            MasterScript.currencyCount += 25;
            SceneManager.LoadScene("MainScene");
        }
    }
}
