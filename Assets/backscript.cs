using UnityEngine;
using UnityEngine.UI;

public class BackButtonController : MonoBehaviour
{
    public Button backButton;
    public GameObject instructionsMenu;

    private bool inInstructionsMenu = false;

    private void OnEnable()
    {
        instructionsMenu.SetActive(false);
        HideBackButton();
    }

    public void ShowBackButton()
    {
        backButton.gameObject.SetActive(true);
    }

    public void HideBackButton()
    {
        backButton.gameObject.SetActive(false);
    }

    public void ToggleInstructionsMenu()
    {
        inInstructionsMenu = !inInstructionsMenu;
        if (inInstructionsMenu)
        {
            ShowBackButton();
            instructionsMenu.SetActive(true);
        }
        else
        {
            HideBackButton();
            instructionsMenu.SetActive(false);
        }
    }
}
