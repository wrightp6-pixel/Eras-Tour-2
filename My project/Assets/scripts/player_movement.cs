using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed

    private Rigidbody2D rb; // Reference to Rigidbody2D
    private Vector2 movement; // Stores movement direction

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Gets Rigidbody2D from the player
    }

    void Update()
    {
        // Get input from keyboard
        movement.x = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right arrows
        movement.y = Input.GetAxisRaw("Vertical");   // W/S or Up/Down arrows
    }

    void FixedUpdate()
    {
        // Move player using Rigidbody2D
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
