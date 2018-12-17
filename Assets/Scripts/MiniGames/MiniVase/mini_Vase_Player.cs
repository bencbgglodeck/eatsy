using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mini_Vase_Player : MonoBehaviour {

    public int score = 0;

    public void Update()
    {
        if(score == 20)
        {
            MasterScript.currencyCount += 25;
            SceneManager.LoadScene("VictoryScene");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        score++;
    }

    public void MoveLeft()
    {
        transform.position = new Vector3(transform.position.x + -1, transform.position.y);
    }

    public void MoveRight()
    {
        transform.position = new Vector3(transform.position.x + 1, transform.position.y);
    }
}
