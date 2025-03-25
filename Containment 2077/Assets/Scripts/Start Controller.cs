using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("Main Game");
    }
}
