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
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private Animator anim;
    private bool landAllowed;
    public GameObject dustEffect;
    public AudioClip driveClip;
    public AudioClip landClip;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        gameObject.GetComponent<AudioSource>().clip = driveClip;
    }
    void Update ()
    {
        anim.SetBool("Jump", !isGrounded);

        rb.velocity = new Vector2(speed, rb.velocity.y);
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        if (isGrounded == true && Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        if (isGrounded == true)
        {
            if (gameObject.GetComponent<AudioSource>().isPlaying == false)
            {
                gameObject.GetComponent<AudioSource>().Play();
            }
            if (landAllowed == true)
            {
                Instantiate(dustEffect, groundCheck.position, Quaternion.identity);
                gameObject.GetComponent<AudioSource>().PlayOneShot(landClip);
                landAllowed = false;
            }
        }
        else
        {
            gameObject.GetComponent<AudioSource>().Pause();
            landAllowed = true;
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
                SceneManager.LoadScene("LoseScene");
            }
        }
        if (collision.gameObject.tag == "CatTag")
        {
            MasterScript.currencyCount = 15 * MasterScript.catLives;
            MasterScript.catLives = 3;
            if (MasterScript.storyLevel == 1)
            {
                MasterScript.storyLevel++;
            }
            SceneManager.LoadScene("VictoryScene");
        }
    }
}
