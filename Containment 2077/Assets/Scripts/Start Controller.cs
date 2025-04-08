using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("Main Game");
    }
    public void OnStartClick2()
    {
        SceneManager.LoadScene("Backstory Screen");
    }
}
