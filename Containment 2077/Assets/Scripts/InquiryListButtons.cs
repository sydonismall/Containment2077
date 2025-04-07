using UnityEngine;

public class InquiryListButtons : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Panel;

    public void OpenTextBod()
    {
        if(Panel != null)
        {
            Panel.SetActive(true);
        }
    }
}
