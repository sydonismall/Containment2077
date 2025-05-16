using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AppearanceAskController : MonoBehaviour
{
    public TMP_Text dynamicTextbox;
    private Coroutine typingCoroutine;
    int doppelVersion;

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
        newText = changeAppearanceDialogue(doppelVersion);
        foreach (char letter in newText)
        {
            dynamicTextbox.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
        typingCoroutine = null;
    }
    public string changeAppearanceDialogue(int doppelVersion)
    {
        this.doppelVersion = doppelVersion;
        if (doppelVersion == 11 || doppelVersion == 12)
        {
            return "Oh, my eyes? I just didn't sleep very well last night.";
        }
        else if (doppelVersion == 13)
        {
            return "Oh, it's all just tomato sauce!";
        }
        else if (doppelVersion == 14)
        {
            return "Uh oh, you caught me. You have to die now.";
        }
        else
        {
            return "What do you mean? There's nothing wrong with my appearance.";
        }
    }
}