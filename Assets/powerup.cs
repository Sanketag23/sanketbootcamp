using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Hide the next obstacle by finding it and calling HideObstacle.
            Obstacle nextObstacle = GameObject.FindObjectOfType<Obstacle>();
            if (nextObstacle != null)
            {
                nextObstacle.HideObstacle();
            }
            // Hide the power-up by disabling its GameObject.
            gameObject.SetActive(false);
        }
    }
}
