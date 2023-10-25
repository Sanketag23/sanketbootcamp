using UnityEngine;
using UnityEngine.UI;

public class BackButtonBehavior : MonoBehaviour
{
    public BackButtonController backButtonController;

    private void Start()
    {
        // Attach the BackButtonController script by finding it in the scene
        backButtonController = FindObjectOfType<BackButtonController>();
    }

    public void OnClick()
    {
        backButtonController.ToggleInstructionsMenu();
    }
}
