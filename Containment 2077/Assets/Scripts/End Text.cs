using TMPro;
using UnityEngine;

public class EndText : MonoBehaviour
{
    public TextMeshProUGUI Text;
    int doppelKilled;
    int doppelSurvived;
    int innoKilled;
    int innoSurvived;

    public EndText(int doppelKilled, int doppelSurvived, int innoKilled, int innoSurvived)
    {
        this.doppelKilled = doppelKilled;
        this.doppelSurvived = doppelSurvived;
        this.innoKilled = innoKilled;
        this.innoSurvived = innoSurvived;
        updateText();
    }
    void updateText()
    {
        Text.text = "Day END\n--------------------------------\nInnocents Survived: " + innoSurvived.ToString() + "\nInnocents Killed: " + innoKilled.ToString() + "\nDoppelgangers Survived: " + doppelSurvived.ToString() + "\nDoppelgangers Killed: " + doppelKilled.ToString();
    }
}
