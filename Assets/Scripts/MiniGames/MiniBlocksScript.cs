using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniBlocksScript : MonoBehaviour
{
    public Transform hole;
    private float dist = 1000000;
    Vector3 originalSize;
    Vector3 temp;
    private bool hold = false;
    private int maxSize = 100;
    private int currentSize = 0;

    private void Start()
    {
        originalSize = transform.localScale;
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10f));
        hold = true;
    }

    private void OnMouseUpAsButton()
    {
        dist = Vector3.Distance(hole.position, transform.position);
        hold = false;
    }

    public void Update()
    {
        if (hold && currentSize < maxSize)
        {
            temp = transform.localScale;
    
            temp.x += Time.deltaTime;
            temp.y += Time.deltaTime;
            transform.localScale = temp;
            currentSize++;
        }

        if (!hold && currentSize > 0)
        {
            temp = transform.localScale;

            temp.x -= Time.deltaTime;
            temp.y -= Time.deltaTime;
            transform.localScale = temp;
            currentSize--;
        }

        if (dist < 1 && currentSize == 0)
        {
            SpriteRenderer so = hole.GetComponent<SpriteRenderer>();
            so.color = new Color(1, 0.92f, 0.016f, 1);

            Destroy(gameObject);
            MasterScript.blockCounter++;
        }
        if (MasterScript.blockCounter >= 3)
        {
            MasterScript.blockCounter = 0;
            MasterScript.currencyCount += 25;
            SceneManager.LoadScene("MainScene");
        }
    }
    
}