using UnityEngine;

public class Character : MonoBehaviour
{
    int characterNum = 0;
    string image;
    string charName;
<<<<<<< HEAD
=======
    public int doppelVersion;

>>>>>>> parent of 142c52f... Revert "a"
    public Character(int characterNum)
    {
        this.characterNum = characterNum;
        if (characterNum == 1)
        {
            charName = "Asher Bertham";
            isDoppelganger();
        }
        // 1: Asher Bertham
        // 2: Paul Daisy 
        // 3: Caetlyn Valence
        // 4: Aimee Mainfield
        // 5: Lidia Trelew
        // 6: Sydney Bantam
        // 7: Jenessa Holly
        // 8: Brian Griffith
        // 9: Gerard Guerlain

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
