using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceButtonScript : MonoBehaviour
{
    public GameObject interfaceBar;
    public GameObject interfaceArrow;

	void Start ()
    {
        interfaceBar.SetActive(false);
	}

    private void OnMouseDown()
    {
        if (gameObject.tag == "InterfaceBarDown")
        {
            interfaceBar.SetActive(true);
            interfaceArrow.SetActive(false);
        }
        else if (gameObject.tag == "InterfaceBarUp")
        {
            interfaceBar.SetActive(false);
            interfaceArrow.SetActive(true);
        }
    }
}
