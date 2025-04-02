using UnityEngine;
using System;

public class MainGame : MonoBehaviour
{
    bool doppelganger = false;
    void Start()
    {
        System.Random rnd = new System.Random();
        int randomNum = rnd.Next(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
