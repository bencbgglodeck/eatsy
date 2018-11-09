using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{   
    public AudioSource audioSource;

    private void Start()
    {

    }
    void Update ()
    {
        audioSource.mute = MasterScript.musicController;
	}
}
