using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has a specific tag, if needed
        // if (other.CompareTag("Player"))
        {
            // Get the name of the current active scene
            string currentSceneName = SceneManager.GetActiveScene().name;

            // Check the current scene and decide which scene to load next
            if (currentSceneName == "Main Scene")
            {
                SceneManager.LoadScene("Dock Scene");
            }
            else if (currentSceneName == "Dock Scene")
            {
                SceneManager.LoadScene("After Boat");
            }
            else if (currentSceneName == "After Boat")
            {
                SceneManager.LoadScene("Space Scene");
            }
            else if (currentSceneName == "Space Scene")
            {
                SceneManager.LoadScene("After Space");
            }
            else if (currentSceneName == "After Space")
            {
                SceneManager.LoadScene("Forest Scene");
            }
            else if (currentSceneName == "Forest Scene")
            {
                SceneManager.LoadScene("After Forest");
            }
            // Add more conditions as needed
            else if (currentSceneName == "After Forest")
            {
                SceneManager.LoadScene("End Screen");
            }
        }
    }
}
