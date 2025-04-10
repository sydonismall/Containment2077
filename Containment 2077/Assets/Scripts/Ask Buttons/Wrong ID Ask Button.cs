using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class InquiryListButtons1 : MonoBehaviour
{
    public TMP_Text dynamicTextbox;
    private Coroutine typingCoroutine;

    public void UpdateText(string text)
    {
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
        }
        typingCoroutine = StartCoroutine(TypeText(text));
    }

    private IEnumerator TypeText(string newText)
    {
        dynamicTextbox.text = "";
        foreach (char letter in newText)
        {
            dynamicTextbox.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
        typingCoroutine = null;
    }
}
