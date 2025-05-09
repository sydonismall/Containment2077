using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    int characterNum;
    public Sprite charImage;
    public Image IDImage;
    public string charName;
    public int doppelVersion;

    public Character(int characterNum)
    {
        this.characterNum = characterNum;
        if (characterNum == 1) { charName = "Asher Bertham"; }
        if (characterNum == 2) { charName = "Paul Daisy"; }
        if (characterNum == 3) { charName = "Caetlyn Valence"; }
        if (characterNum == 4) { charName = "Aimee Mainfield"; }
        if (characterNum == 5) { charName = "Lidia Trelew"; }
        if (characterNum == 6) { charName = "Sydney Bantam"; }
        if (characterNum == 7) { charName = "Jenessa Holly"; }
        if (characterNum == 8) { charName = "Brian Griffith"; }
        if (characterNum == 9) { charName = "Gerard Guerlaih"; }

        System.Random rnd = new System.Random();
        doppelVersion = rnd.Next(1, 19);
        // doppvers 1 - 10: normal character
        // 11: appearance eyes
        // 12: appearance eyes2
        // 13: appearance blood
        // 14: appearance wc
        // 15: wrong ID
        // 16: missing ID
        // 17: personal
        // 18: alibi
        // 19: today's list
        if (doppelVersion <= 10 || doppelVersion >= 15) { SetAppearanceDefault(characterNum); }
        if (doppelVersion >= 11 && doppelVersion <= 14) { SetAppearanceDoppel(characterNum, doppelVersion); }
        if (doppelVersion != 15 && doppelVersion != 16) { SetIDDefault(characterNum); }
        if (doppelVersion == 15) { }
        if (doppelVersion == 16) { }
        if (doppelVersion == 17) { }
        if (doppelVersion == 18) { } 
        if (doppelVersion == 19) { } // dialogue + image
    }

    public void SetIDDefault(int characterNum)
    {

    }
    
    public void SetAppearanceDefault(int characterNum)
    {
        if (characterNum == 1) { charImage = Resources.Load<Sprite>("abdefault"); }
        if (characterNum == 2) { charImage = Resources.Load<Sprite>("pddefault"); }
        if (characterNum == 3) { charImage = Resources.Load<Sprite>("cvdefault"); }
        if (characterNum == 4) { charImage = Resources.Load<Sprite>("amdefault"); }
        if (characterNum == 5) { charImage = Resources.Load<Sprite>("ltdefault"); }
        if (characterNum == 6) { charImage = Resources.Load<Sprite>("sbdefault"); }
        if (characterNum == 7) { charImage = Resources.Load<Sprite>("jhdefault"); }
        if (characterNum == 8) { charImage = Resources.Load<Sprite>("bgdefault"); }
        if (characterNum == 9) { charImage = Resources.Load<Sprite>("ggdefault"); }
    }
    public void SetAppearanceDoppel(int characterNum, int doppelVersion)
    {
        if (doppelVersion == 11) {
            if (characterNum == 1) { charImage = Resources.Load<Sprite>("abeyes"); }
            if (characterNum == 2) { charImage = Resources.Load<Sprite>("pdeyes"); }
            if (characterNum == 3) { charImage = Resources.Load<Sprite>("cveyes"); }
            if (characterNum == 4) { charImage = Resources.Load<Sprite>("ameyes"); }
            if (characterNum == 5) { charImage = Resources.Load<Sprite>("lteyes"); }
            if (characterNum == 6) { charImage = Resources.Load<Sprite>("sbeyes"); }
            if (characterNum == 7) { charImage = Resources.Load<Sprite>("jheyes"); }
            if (characterNum == 8) { charImage = Resources.Load<Sprite>("bgeyes"); }
            if (characterNum == 9) { charImage = Resources.Load<Sprite>("ggeyes"); }
        }
        if (doppelVersion == 12) {
            if (characterNum == 1) { charImage = Resources.Load<Sprite>("abeyes2"); }
            if (characterNum == 2) { charImage = Resources.Load<Sprite>("pdeyes2"); }
            if (characterNum == 3) { charImage = Resources.Load<Sprite>("cveyes2"); }
            if (characterNum == 4) { charImage = Resources.Load<Sprite>("ameyes2"); }
            if (characterNum == 5) { charImage = Resources.Load<Sprite>("lteyes2"); }
            if (characterNum == 6) { charImage = Resources.Load<Sprite>("sbeyes2"); }
            if (characterNum == 7) { charImage = Resources.Load<Sprite>("jheyes2"); }
            if (characterNum == 8) { charImage = Resources.Load<Sprite>("bgeyes2"); }
            if (characterNum == 9) { charImage = Resources.Load<Sprite>("ggeyes2"); }
        }
        if (doppelVersion == 13) {
            if (characterNum == 1) { charImage = Resources.Load<Sprite>("abblood"); }
            if (characterNum == 2) { charImage = Resources.Load<Sprite>("pdblood"); }
            if (characterNum == 3) { charImage = Resources.Load<Sprite>("cvblood"); }
            if (characterNum == 4) { charImage = Resources.Load<Sprite>("amblood"); }
            if (characterNum == 5) { charImage = Resources.Load<Sprite>("ltblood"); }
            if (characterNum == 6) { charImage = Resources.Load<Sprite>("sbblood"); }
            if (characterNum == 7) { charImage = Resources.Load<Sprite>("jhblood"); }
            if (characterNum == 8) { charImage = Resources.Load<Sprite>("bgblood"); }
            if (characterNum == 9) { charImage = Resources.Load<Sprite>("ggblood"); }
        }
        if (doppelVersion == 14) {
            if (characterNum == 1) { charImage = Resources.Load<Sprite>("abwildcard"); }
            if (characterNum == 2) { charImage = Resources.Load<Sprite>("pdwildcard"); }
            if (characterNum == 3) { charImage = Resources.Load<Sprite>("cvwildcard"); }
            if (characterNum == 4) { charImage = Resources.Load<Sprite>("amwildcard"); }
            if (characterNum == 5) { charImage = Resources.Load<Sprite>("ltwildcard"); }
            if (characterNum == 6) { charImage = Resources.Load<Sprite>("sbwildcard"); }
            if (characterNum == 7) { charImage = Resources.Load<Sprite>("jhwildcard"); }
            if (characterNum == 8) { charImage = Resources.Load<Sprite>("bgwildcard"); }
            if (characterNum == 9) { charImage = Resources.Load<Sprite>("ggwildcard"); }
        }
    }
}