using UnityEngine;

public class Oscillator : MonoBehaviour
{
    private Vector3 startPosition; // The initial position of the object, used as the oscillation center if no custom center is provided

    [SerializeField] private Vector3 oscillationDirection = new Vector3(1, 0, 0); // Direction of oscillation (e.g., x-axis, y-axis, etc.)
    [SerializeField] private float amplitude = 1f; // The maximum distance from the center of oscillation
    [SerializeField] private float frequency = 1f; // The speed of oscillation (higher value = faster movement)
    [SerializeField] private float offset = 0f; // A time offset to allow starting the oscillation at different phases
    [SerializeField] private Vector3? customCenter = null; // An optional custom center for the oscillation

    private void Start()
    {
        // Set the starting position as the oscillation center
        // If no custom center is defined, use the object's initial position
        startPosition = customCenter ?? transform.position;
    }

    private void Update()
    {
        // Calculate the oscillation value using the sine function
        // The sine function ensures smooth acceleration and deceleration
        float oscillation = Mathf.Sin(Time.time * frequency + offset) * amplitude;

        // Update the object's position by adding the oscillation to the center position
        transform.position = startPosition + oscillation * oscillationDirection;
    }
}
