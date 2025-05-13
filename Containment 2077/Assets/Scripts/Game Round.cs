using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class GameRound : MonoBehaviour
{
    public List<Character> TodayList;
    public int currentIndex;
    public GameObject personPrefab;
    public GameObject idPrefab;
    public GameObject canvas;
    private GameObject personObject;
    private GameObject idObject;
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
        spawnNextPerson();
    }

    public void spawnNextPerson()
    {
        personObject = Instantiate(personPrefab);
        personObject.GetComponent<Image>().sprite = TodayList[currentIndex].charImage;
        personObject.transform.parent = canvas.transform;
        personObject.transform.position = new Vector3(500, 260, 0);

        idObject = Instantiate(idPrefab);
        idObject.GetComponent<Image>().sprite = TodayList[currentIndex].IDImage;
        idObject.transform.parent = canvas.transform;
        idObject.transform.position = new Vector3(500, 50, 0);

        currentIndex++;
        
    }
    public void DespawnPerson()
    {
        Destroy(personObject);
        Destroy(idObject);
        if (currentIndex != 3)
        {
            spawnNextPerson();
        }
    }

}
