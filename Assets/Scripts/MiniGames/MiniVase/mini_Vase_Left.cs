using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mini_Vase_Left : MonoBehaviour {

    public GameObject player;

    private void OnMouseDown()
    {
        player.GetComponent<mini_Vase_Player>().MoveLeft();
    }
}
