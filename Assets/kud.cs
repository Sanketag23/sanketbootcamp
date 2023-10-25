using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rb;
    bool canJump;  // Use a variable to control whether the character can jump.
    public float JumpForce = 100f;

    // Start is called before the first frame update
    void Start()
    {
        canJump = true;  // Initially, the character can jump.
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            DoJump();
        }
    }

    void DoJump() // Renamed the method to "DoJump"
    {
        rb.velocity = Vector2.up * JumpForce; // Set the velocity directly to achieve a fixed height jump.
        canJump = false;  // The character cannot jump until they touch the ground again.
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;  // Reset the ability to jump when touching the ground.
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = false;  // Prevent jumping while in the air.
        }
    }
}
