using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniSpices : MonoBehaviour
{
    public Transform pot;
    private float dist = 1000000;
    Vector3 originalSize;
    Vector3 originalPos;
    Vector3 temp;
    private bool hold = false;
    private int maxSize = 50;
    private int currentSize = 0;
    private bool currentlyUsed = false;
    public int spiceId;

    private void Start()
    {
        originalSize = transform.localScale;
        originalPos = transform.position;
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        hold = true;
        currentlyUsed = true;
    }

    private void OnMouseUpAsButton()
    {
        dist = Vector3.Distance(pot.position, transform.position);
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

        if (!hold)
        {
            //Return to og position
            transform.position = originalPos;
            transform.localScale = originalSize;
            currentSize = 0;
        }

        if (dist < 1 && currentSize == 0 && currentlyUsed == true)
        {
            dist = 1000;
            transform.position = originalPos;
            MiniFood.usedSpice = spiceId;
            currentlyUsed = false;
        }
    }

}
