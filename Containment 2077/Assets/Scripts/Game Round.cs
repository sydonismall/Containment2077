using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameRound : MonoBehaviour
{
    public List<Character> TodayList;
    public int currentIndex;
    public GameObject personPrefab;
    public GameObject idPrefab;
    public GameObject canvas;
    public TMP_Text dialogueText;
    private GameObject personObject;
    private GameObject idObject;
    public int doppelKilled;
    public int doppelSurvived;
    public int innoKilled;
    public int innoSurvived;
    public TMP_Text dynamicTextbox;
    private Coroutine typingCoroutine;


    void Start()
    {
        currentIndex = 0;
        TodayList = new List<Character>();

        for (int i = 0; i <= 4; i++)
        {
            int randChar = Random.Range(1, 10); // Using Unity's Random

            // Create a new GameObject to hold the Character component
            GameObject charHolder = new GameObject("Character_" + randChar);
            charHolder.transform.SetParent(transform); // Make it a child of this object

            // Add the Character component
            Character newChar = charHolder.AddComponent<Character>();
            newChar.Initialize(randChar, dialogueText);
            TodayList.Add(newChar);
        }

        spawnNextPerson();
    }

    public void spawnNextPerson()
    {
        if (currentIndex >= TodayList.Count) return;

        personObject = Instantiate(personPrefab);
        personObject.GetComponent<Image>().sprite = TodayList[currentIndex].charImage;
        personObject.transform.parent = canvas.transform;
        personObject.transform.position = new Vector3(960, 400, 0);

        idObject = Instantiate(idPrefab);
        idObject.GetComponent<Image>().sprite = TodayList[currentIndex].IDImage;
        idObject.transform.parent = canvas.transform;
        idObject.transform.position = new Vector3(960, 200, 0);

        currentIndex++;
    }

    public void UnlockDespawnPerson()
    {
        if (TodayList[currentIndex].doppelVersion <= 10)
        {
            innoSurvived++;
        }
        else
        {
            doppelSurvived++;
        }
        Destroy(personObject);
        Destroy(idObject);
        if (currentIndex < TodayList.Count - 1)
        {
            spawnNextPerson();
        }
        else
        {
            SceneManager.LoadScene("End Screen");
            new EndText(doppelKilled, doppelSurvived, innoKilled, innoSurvived);
        }
    }

    public void DialDespawnPerson()
    {
        if (TodayList[currentIndex].doppelVersion <= 10)
        {
            innoKilled++;
        }
        else
        {
            doppelKilled++;
        }
        Destroy(personObject);
        Destroy(idObject);
        if (currentIndex < TodayList.Count - 1)
        {
            spawnNextPerson();
        }
        else
        {
            SceneManager.LoadScene("End Screen");
            new EndText(doppelKilled, doppelSurvived, innoKilled, innoSurvived);
        }

    }
    public void UpdateAppearanceText(string text)
    {
        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);
        typingCoroutine = StartCoroutine(TypeAppearanceText(text));
    }

    private IEnumerator TypeAppearanceText(string newText)
    {
        dynamicTextbox.text = "";
        newText = changeAppearanceDialogue();
        foreach (char letter in newText)
        {
            dynamicTextbox.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
        typingCoroutine = null;
    }

    public string changeAppearanceDialogue()
    {
        if (TodayList[currentIndex].doppelVersion == 11 || TodayList[currentIndex].doppelVersion == 12)
            return "Oh, my eyes? I just didn't sleep very well last night.";
        else if (TodayList[currentIndex].doppelVersion == 13)
            return "Oh, it's all just tomato sauce!";
        else if (TodayList[currentIndex].doppelVersion == 14)
            return "Uh oh, you caught me. You have to die now.";
        else
            return "What do you mean? There's nothing wrong with my appearance.";
    }

    public void UpdateWrongIDText(string text)
    {
        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);
        typingCoroutine = StartCoroutine(TypeWrongIDText(text));
    }

    private IEnumerator TypeWrongIDText(string newText)
    {
        dynamicTextbox.text = "";
        newText = changeWrongIDDialogue();
        foreach (char letter in newText)
        {
            dynamicTextbox.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
        typingCoroutine = null;
    }

    public string changeWrongIDDialogue()
    {
        if (TodayList[currentIndex].doppelVersion == 15)
            return "Oh, that. Don't worry, it's just wear and tear.";
        else
            return "My ID should be correct.";
    }

    public void UpdateMissingIDText(string text)
    {
        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);
        typingCoroutine = StartCoroutine(TypeMissingIDText(text));
    }

    private IEnumerator TypeMissingIDText(string newText)
    {
        dynamicTextbox.text = "";
        newText = changeMissingIDDialogue();
        foreach (char letter in newText)
        {
            dynamicTextbox.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
        typingCoroutine = null;
    }

    public string changeMissingIDDialogue()
    {
        if (TodayList[currentIndex].doppelVersion == 16)
            return "Sorry, I lost it outside of the shelter. I'll ask for a new one once I'm in.";
        else
            return "I have provided my ID already.";
    }

    public void UpdatePersonalText(string text)
    {
        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);
        typingCoroutine = StartCoroutine(TypePersonalText(text));
    }

    private IEnumerator TypePersonalText(string newText)
    {
        dynamicTextbox.text = "";
        newText = changePersonalDialogue();
        foreach (char letter in newText)
        {
            dynamicTextbox.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
        typingCoroutine = null;
    }

    public string changePersonalDialogue()
    {
        if (TodayList[currentIndex].doppelVersion == 17) {
            return "Hm? About me? Sorry, I would like to chat about myself, but I'm really tired right now.";
        }
            
    switch (TodayList[currentIndex].characterNum)
        {
            case 1: return "Oh, sure. I'm very interested in weather, and that led me to study conditions for the shelter.";
            case 2: return "Yeah, I'm a technical guy, I like working with hands-on stuff. Like circuits.";
            case 3: return "I'm very passionate about justice. Everyone deserves a chance.";
            case 4: return "Brains really interest me. Like, how they work. I like the science of it.";
            case 5: return "The lab is basically my home, and chemicals are my best friends.";
            case 6: return "I love love love music. No one loves performing like I do.";
            case 7: return "Well, I guess I'm a very curious person. I ask a lot of questions. Why do you want to know?";
            case 8: return "One might say that I'm a bit of a chef. Been learning all the new techniques during ventures lately.";
            case 9: return "I really like' money. Is that bad to say?";
            default: return "";
        }
        
    }

    public void UpdateAlibiText(string text)
    {
        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);
        typingCoroutine = StartCoroutine(TypeAlibiText(text));
    }

    private IEnumerator TypeAlibiText(string newText)
    {
        dynamicTextbox.text = "";
        newText = changeAlibiDialogue();
        foreach (char letter in newText)
        {
            dynamicTextbox.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
        typingCoroutine = null;
    }

    public string changeAlibiDialogue()
    {
        if (TodayList[currentIndex].doppelVersion == 18) {
        return "What I was doing out? Oh, you know, just exploring'";
      }

            switch (TodayList[currentIndex].characterNum)
            {
                case 1: return "I was checking the weather for today so I can create a forecast.";
                case 2: return "I needed some new electrical parts from the junkyard.";
                case 3: return "Took a quick break, wanted to inspire my brain by the injustice and havoc done to our world.";
                case 4: return "Well, I don't know. Impulsive decisions. Interesting how the brain will decide that, right?";
                case 5: return "I wanted to test the outside soil's reaction to a formulated chemical compound.";
                case 6: return "Um, singing to the trees, of course. Even the dead branches need some uplifting.";
                case 7: return "I'm starting a new research project that involves the outside world. Needed to gather data.";
                case 8: return "I was just looking for a new animal mutation for the shelter's steak tonight.";
                case 9: return "Always surveying the area for factors that might surprise attack our finances. Can never be too careful.";
                default: return "";
            }
        }

    public void UpdateFileText(string text)
    {
        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);
        typingCoroutine = StartCoroutine(TypeFileText(text));
    }

    private IEnumerator TypeFileText(string newText)
    {
        dynamicTextbox.text = "";
        newText = changeFileDialogue();
        foreach (char letter in newText)
        {
            dynamicTextbox.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
        typingCoroutine = null;
    }

    public string changeFileDialogue()
    {
        if (TodayList[currentIndex].doppelVersion == 19) {
            return "How rude! You should never ask a stranger how old they are and what they do.";
        }
        switch (TodayList[currentIndex].characterNum)
        {
            case 1: return "Well, I study weather, and I'm hopefully not too old for the job.";
            case 2: return "I work with the electric parts of the shelter, such hard work for a guy as old as me.";
            case 3: return "I'm a lawyer, and hopefully I can become a judge soon in 5 years once I'm 35.";
            case 4: return "I work with neuroscience, of course! And I'm 40.";
            case 5: return "I work with chemicals, but who knows what the point is. The world is ending anyway.";
            case 6: return "I create music for others in the shelter! Come to my next show. Well, not really a full show'";
            case 7: return "I do research, of course. Someone needs to be smart around here, though I'm barely in my 30s.";
            case 8: return "I'm the hunter. Cooler name than scavenger. Yeah, pretty young for the job.";
            case 9: return "I work with Jessica. Great woman, she's like an older sister.";
            default: return "";
        }
    }

}