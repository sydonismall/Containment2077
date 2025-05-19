using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Character : MonoBehaviour
{
    public int characterNum;
    public Sprite charImage;
    public Sprite IDImage;
    public string charName;
    public int doppelVersion;

    // Initialize character with a number
    public void Initialize(int characterNum, TMP_Text textbox)
    {
        Debug.Log($"Initializing character #{characterNum}");

        this.characterNum = characterNum;
        

        // Set character name
        switch (characterNum)
        {
            case 1:
                charName = "Asher Bertham";
                Debug.Log("Character name set to: Asher Bertham");
                break;
            case 2:
                charName = "Paul Daisy";
                Debug.Log("Character name set to: Paul Daisy");
                break;
            case 3:
                charName = "Caetlyn Valence";
                Debug.Log("Character name set to: Caetlyn Valence");
                break;
            case 4:
                charName = "Aimee Mainfield";
                Debug.Log("Character name set to: Aimee Mainfield");
                break;
            case 5:
                charName = "Lidia Trelew";
                Debug.Log("Character name set to: Lidia Trelew");
                break;
            case 6:
                charName = "Sydney Bantam";
                Debug.Log("Character name set to: Sydney Bantam");
                break;
            case 7:
                charName = "Jenessa Holly";
                Debug.Log("Character name set to: Jenessa Holly");
                break;
            case 8:
                charName = "Brian Griffith";
                Debug.Log("Character name set to: Brian Griffith");
                break;
            case 9:
                charName = "Gerard Guerlaih";
                Debug.Log("Character name set to: Gerard Guerlaih");
                break;
            default:
                charName = "Unknown";
                Debug.LogWarning($"Unknown character number: {characterNum}");
                break;
        }

        System.Random rnd = new System.Random();
        doppelVersion = rnd.Next(1, 20); // 1 to 19

        // Appearance
        if (doppelVersion <= 10)
        {
            SetAppearanceDefault(characterNum);
        }
        else if (doppelVersion >= 11 && doppelVersion <= 14)
        {
            SetAppearanceDoppel(characterNum, doppelVersion);
        }
        else
        {
            SetAppearanceDefault(characterNum);
        }

        // ID
        if (doppelVersion == 15)
        {
            SetIDDoppel(characterNum);
        }
        else if (doppelVersion == 16)
        {
            IDImage = null;
        }
        else
        {
            SetIDDefault(characterNum);
        }
    }

    public void SetIDDefault(int characterNum)
    {
        switch (characterNum)
        {
            case 1: IDImage = Resources.Load<Sprite>("abid"); break;
            case 2: IDImage = Resources.Load<Sprite>("pdid"); break;
            case 3: IDImage = Resources.Load<Sprite>("cvid"); break;
            case 4: IDImage = Resources.Load<Sprite>("amid"); break;
            case 5: IDImage = Resources.Load<Sprite>("ltid"); break;
            case 6: IDImage = Resources.Load<Sprite>("sbid"); break;
            case 7: IDImage = Resources.Load<Sprite>("jhid"); break;
            case 8: IDImage = Resources.Load<Sprite>("bgid"); break;
            case 9: IDImage = Resources.Load<Sprite>("ggid"); break;
        }
    }

    public void SetIDDoppel(int characterNum)
    {
        switch (characterNum)
        {
            case 1: IDImage = Resources.Load<Sprite>("abwrongid"); break;
            case 2: IDImage = Resources.Load<Sprite>("pdwrongid"); break;
            case 3: IDImage = Resources.Load<Sprite>("cvwrongid"); break;
            case 4: IDImage = Resources.Load<Sprite>("amwrongid"); break;
            case 5: IDImage = Resources.Load<Sprite>("ltwrongid"); break;
            case 6: IDImage = Resources.Load<Sprite>("sbwrongid"); break;
            case 7: IDImage = Resources.Load<Sprite>("jhwrongid"); break;
            case 8: IDImage = Resources.Load<Sprite>("bgwrongid"); break;
            case 9: IDImage = Resources.Load<Sprite>("ggwrongid"); break;
        }
    }

    public void SetAppearanceDefault(int characterNum)
    {
        switch (characterNum)
        {
            case 1: charImage = Resources.Load<Sprite>("abdefault"); break;
            case 2: charImage = Resources.Load<Sprite>("pddefault"); break;
            case 3: charImage = Resources.Load<Sprite>("cvdefault"); break;
            case 4: charImage = Resources.Load<Sprite>("amdefault"); break;
            case 5: charImage = Resources.Load<Sprite>("ltdefault"); break;
            case 6: charImage = Resources.Load<Sprite>("sbdefault"); break;
            case 7: charImage = Resources.Load<Sprite>("jhdefault"); break;
            case 8: charImage = Resources.Load<Sprite>("bgdefault"); break;
            case 9: charImage = Resources.Load<Sprite>("ggdefault"); break;
        }
    }

    public void SetAppearanceDoppel(int characterNum, int doppelVersion)
    {
        if (doppelVersion == 11)
        {
            switch (characterNum)
            {
                case 1: charImage = Resources.Load<Sprite>("abeyes"); break;
                case 2: charImage = Resources.Load<Sprite>("pdeyes"); break;
                case 3: charImage = Resources.Load<Sprite>("cveyes"); break;
                case 4: charImage = Resources.Load<Sprite>("ameyes"); break;
                case 5: charImage = Resources.Load<Sprite>("lteyes"); break;
                case 6: charImage = Resources.Load<Sprite>("sbeyes"); break;
                case 7: charImage = Resources.Load<Sprite>("jheyes"); break;
                case 8: charImage = Resources.Load<Sprite>("bgeyes"); break;
                case 9: charImage = Resources.Load<Sprite>("ggeyes"); break;
            }
        }
        else if (doppelVersion == 12)
        {
            switch (characterNum)
            {
                case 1: charImage = Resources.Load<Sprite>("abeyes2"); break;
                case 2: charImage = Resources.Load<Sprite>("pdeyes2"); break;
                case 3: charImage = Resources.Load<Sprite>("cveyes2"); break;
                case 4: charImage = Resources.Load<Sprite>("ameyes2"); break;
                case 5: charImage = Resources.Load<Sprite>("lteyes2"); break;
                case 6: charImage = Resources.Load<Sprite>("sbeyes2"); break;
                case 7: charImage = Resources.Load<Sprite>("jheyes2"); break;
                case 8: charImage = Resources.Load<Sprite>("bgeyes2"); break;
                case 9: charImage = Resources.Load<Sprite>("ggeyes2"); break;
            }
        }
        else if (doppelVersion == 13)
        {
            switch (characterNum)
            {
                case 1: charImage = Resources.Load<Sprite>("abblood"); break;
                case 2: charImage = Resources.Load<Sprite>("pdblood"); break;
                case 3: charImage = Resources.Load<Sprite>("cvblood"); break;
                case 4: charImage = Resources.Load<Sprite>("amblood"); break;
                case 5: charImage = Resources.Load<Sprite>("ltblood"); break;
                case 6: charImage = Resources.Load<Sprite>("sbblood"); break;
                case 7: charImage = Resources.Load<Sprite>("jhblood"); break;
                case 8: charImage = Resources.Load<Sprite>("bgblood"); break;
                case 9: charImage = Resources.Load<Sprite>("ggblood"); break;
            }
        }
        else if (doppelVersion == 14)
        {
            switch (characterNum)
            {
                case 1: charImage = Resources.Load<Sprite>("abwildcard"); break;
                case 2: charImage = Resources.Load<Sprite>("pdwildcard"); break;
                case 3: charImage = Resources.Load<Sprite>("cvwildcard"); break;
                case 4: charImage = Resources.Load<Sprite>("amwildcard"); break;
                case 5: charImage = Resources.Load<Sprite>("ltwildcard"); break;
                case 6: charImage = Resources.Load<Sprite>("sbwildcard"); break;
                case 7: charImage = Resources.Load<Sprite>("jhwildcard"); break;
                case 8: charImage = Resources.Load<Sprite>("bgwildcard"); break;
                case 9: charImage = Resources.Load<Sprite>("ggwildcard"); break;
            }
        }
    }

    
}

