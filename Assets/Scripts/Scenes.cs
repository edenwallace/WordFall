using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene("Main");
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("Exit");
    }

    public void ExitGame()
    {
        
        Application.Quit();
        
    }
}
