using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Main Scene"); // Replace "GameScene" with the name of your game scene
    }

    public void QuitGame()
    {
        Application.Quit();
        // If running in the editor:
        // UnityEditor.EditorApplication.isPlaying = false;
    }

    public void OpenOptions()
    {
        // Code to open options menu
    }
}
