using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 30f; // Rotation speed around the Y axis
    // Update is called once per frame
    void Update()
    {
        // Rotate the object around the vertical axis (Y) by the specified speed
        // The rotation is based on the speed and deltaTime to ensure smooth rotation over time
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
