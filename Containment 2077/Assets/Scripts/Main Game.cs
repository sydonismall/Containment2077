using UnityEngine;
using System;

public class isDoppelganger : MonoBehaviour
{
    bool doppelganger = false;
    void Start()
    {
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
            int whichAppear = rnd.Next(1, 5);
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
