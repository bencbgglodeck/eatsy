using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniBlocksScript : MonoBehaviour
{
    public Transform hole;
    public GameObject boxPart;
    private float dist = 1000000;
    //Vector3 originalSize;
    Vector3 temp;
    private bool hold = false;
    private int maxSize = 50;
    private int currentSize = 0;

    private void Start()
    {
        boxPart.SetActive(false);
        //originalSize = transform.localScale;
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
    
            temp.x += Time.deltaTime*2;
            temp.y += Time.deltaTime*2;
            transform.localScale = temp;
            currentSize++;
        }

        if (!hold && currentSize > 0)
        {
            temp = transform.localScale;

            temp.x -= Time.deltaTime*2;
            temp.y -= Time.deltaTime*2;
            transform.localScale = temp;
            currentSize--;
        }

        if (dist < 1 && currentSize == 0)
        {
            boxPart.SetActive(true);

            Destroy(gameObject);
            MasterScript.blockCounter++;
        }
        if (MasterScript.blockCounter >= 4)
        {
            MasterScript.blockCounter = 0;
            MasterScript.currencyCount += 25;
            SceneManager.LoadScene("MainScene");
        }
    }
    
}