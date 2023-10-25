using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private bool shouldShow = true;

    private void Start()
    {
        // Ensure the obstacle is initially visible.
        ShowObstacle();
    }

    private void Update()
    {
        // Check if the obstacle should be visible based on the power-up collected status.
        if (shouldShow)
        {
            ShowObstacle();
        }
        else
        {
            HideObstacle();
        }
    }

    public void HideObstacle()
    {
        shouldShow = false;
        gameObject.SetActive(false);
    }

    public void ShowObstacle()
    {
        shouldShow = true;
        gameObject.SetActive(true);
    }
}
