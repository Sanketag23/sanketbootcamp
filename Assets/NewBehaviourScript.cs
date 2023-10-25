using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public string previousSceneName; // If you want to load a previous scene, you can specify its name here.

    public void OnBackButtonClick()
    {
        // Implement the logic to go back to the previous screen or scene.
        // For example, you can load a scene or deactivate the current instructions panel.
        if (!string.IsNullOrEmpty(previousSceneName))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(previousSceneName);
        }
        else
        {
            gameObject.SetActive(false); // Deactivate the instructions panel.
        }
    }
}
