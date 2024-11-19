using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float moveSpeed = 5f;

    void Update()
    {
        // Initialize movement vector
        Vector3 movement = Vector3.zero;

        // Check for specific keys and update movement accordingly
        if (Input.GetKey(KeyCode.W)) // Move forward
        {
            movement += Vector3.up;
        }
        if (Input.GetKey(KeyCode.S)) // Move backward
        {
            movement += Vector3.down;
        }
        if (Input.GetKey(KeyCode.A)) // Move left
        {
            movement += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D)) // Move right
        {
            movement += Vector3.right;
        }

        // Apply movement
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }
}
