using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class GameRound : MonoBehaviour
{
    public List<Character> TodayList;
    public int currentIndex;
    public GameObject personPrefab;
    public GameObject canvas;
    public void Start()
    {
        currentIndex = 0;
        TodayList = new List<Character>();
        for (int i = 0; i < 4; i++)
        {
            System.Random rnd = new System.Random();
            int randChar = rnd.Next(1,9);
            TodayList.Add(new Character(randChar));
        }
        print("CHARACTER LIST INITIALIZED");
        print("PERSON 0 IS: " + TodayList[0].charName);
        spawnNextPerson();
    }

    public void spawnNextPerson()
    {
        GameObject personObject = Instantiate(personPrefab);
        print(TodayList[currentIndex].charImage);
        personObject.GetComponent<Image>().sprite = TodayList[currentIndex].charImage;
        personObject.transform.parent = canvas.transform;
        personObject.transform.position = new Vector3(500, 260, 0);
        print("SPAWNED IN PERSON #: " + currentIndex);
        currentIndex++;
        
    }

}
