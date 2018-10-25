using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update ()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        if (isGrounded == true && Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
            MasterScript.catLives--;
            if (MasterScript.catLives > 0)
            {
                SceneManager.LoadScene("MiniCat");
            }
            else if (MasterScript.catLives <= 0)
            {
                MasterScript.catLives = 3;
                SceneManager.LoadScene("MainScene");
            }
        }
        if (collision.gameObject.tag == "CatTag")
        {
            MasterScript.currencyCount = 15 * MasterScript.catLives;
            MasterScript.catLives = 3;
            SceneManager.LoadScene("MainScene");
        }
    }
}
