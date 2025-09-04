using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class EndScreenController : MonoBehaviour
{
    public TextMeshProUGUI endText; // Use Text if not using TextMeshPro
    public float fadeDuration = 2f; // Duration of fade in/out
    public float displayDuration = 2f; // Time the text stays visible

    private void Start()
    {
        endText.color = new Color(endText.color.r, endText.color.g, endText.color.b, 0); // Start with invisible text
        StartCoroutine(FadeText());
    }

    private IEnumerator FadeText()
    {
        // Fade In
        for (float t = 0.01f; t < fadeDuration; t += Time.deltaTime)
        {
            endText.color = new Color(endText.color.r, endText.color.g, endText.color.b, Mathf.Lerp(0, 1, t / fadeDuration));
            yield return null;
        }

        yield return new WaitForSeconds(displayDuration);

        // Fade Out
        for (float t = 0.01f; t < fadeDuration; t += Time.deltaTime)
        {
            endText.color = new Color(endText.color.r, endText.color.g, endText.color.b, Mathf.Lerp(1, 0, t / fadeDuration));
            yield return null;
        }

        // Load Main Menu Scene
        SceneManager.LoadScene("Main Menu"); // Replace with your Main Menu scene name
    }
}
