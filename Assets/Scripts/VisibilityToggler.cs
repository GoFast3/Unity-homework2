using UnityEngine;
using UnityEngine.InputSystem; // For InputAction support

public class VisibilityToggler : MonoBehaviour
{
    [SerializeField] private InputAction toggleVisibilityAction; // Input action for toggling visibility
    private Renderer objectRenderer; // Renderer component to manage visibility

    private void Awake()
    {
        // Cache the Renderer component
        objectRenderer = GetComponent<Renderer>();

        // Ensure the InputAction is enabled
        if (toggleVisibilityAction != null)
        {
            toggleVisibilityAction.Enable();
        }
    }

    private void OnEnable()
    {
        // Bind the input action to the ToggleVisibility method
        if (toggleVisibilityAction != null)
        {
            toggleVisibilityAction.performed += ToggleVisibility;
        }
    }

    private void OnDisable()
    {
        // Unbind the input action to avoid memory leaks
        if (toggleVisibilityAction != null)
        {
            toggleVisibilityAction.performed -= ToggleVisibility;
        }
    }

    private void ToggleVisibility(InputAction.CallbackContext context)
    {
        // Toggle the visibility by enabling/disabling the Renderer component
        if (objectRenderer != null)
        {
            objectRenderer.enabled = !objectRenderer.enabled;
        }
    }
}
