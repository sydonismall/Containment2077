using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InquiryListButtons : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Text Textfield;


    public void SetText(string text)
    {
        Textfield.text = text;
    }
}
