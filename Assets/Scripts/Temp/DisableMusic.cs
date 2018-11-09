using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMusic : MonoBehaviour
{
    public void MusicDisabler()
    {
        if(MasterScript.musicController == true)
        {
            MasterScript.musicController = false;
        } else if (MasterScript.musicController == false)
            {
                MasterScript.musicController = true;
            }
    }
}
