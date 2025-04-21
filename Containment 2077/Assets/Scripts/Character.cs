using UnityEngine;

public class Character : MonoBehaviour
{
    int characterNum = 0;
    string image;
    string charName;
    int doppelVersion;
    
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
        if (characterNum == 9) { charName = "Brian Griffith"; }
        // doppvers 1 - 15: normal character
        // 16: dopp appearance
        // 17: 
    }
    public void isDoppelganger()
    {
        bool doppelganger = false;
        System.Random rnd = new System.Random();
        int randomNum = rnd.Next(1, 4);
        if (randomNum == 1)
        {
            doppelganger = true;
        }
        if (doppelganger == true)
        {
            createDoppelganger(rnd.Next(1, 6));
        }
    }
    public void createDoppelganger(int doppVersion)
    {
        System.Random rnd = new System.Random();
        if (doppVersion == 1) // appearance
        {
            int whichAppear = rnd.Next(1, 2);
            if (whichAppear == 1)
            {
                image = "";
            }
        }
        if (doppVersion == 2) // wrong ID
        {
            int whichID = rnd.Next(1, 2);
            if (whichID == 1)
            {

            }
        }
        if (doppVersion == 3) // missing ID
        {

        }
        if (doppVersion == 4) // personal
        {

        }
        if (doppVersion == 5) // alibi
        {

        }
        if (doppVersion == 6) // today's list
        {

        }

    }
}
