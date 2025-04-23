using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneButtonHover : MonoBehaviour
{
    public GameObject hoverText;
    void Start()
    {
        hoverText.SetActive(false);
    }

    // Update is called once per frame
    public void OnMouseOver()
    {
        hoverText.SetActive(true);
    }
    public void OnMouseExit()
    {
        hoverText.SetActive(false);
    }
}
