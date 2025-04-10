using UnityEngine;
using System.Collections.Generic;

public class GameRound : MonoBehaviour
{
    bool playing = true;
    public void TraverseRound()
    {
        while (playing)
        {
            List<Character> TodayList = new List<Character>();
            for (int i = 0; i < 4; i++)
            {
                System.Random rnd = new System.Random();
                int randChar = rnd.Next(1,9);
                TodayList.Add(new Character(randChar));
            }
        }
    }

}
