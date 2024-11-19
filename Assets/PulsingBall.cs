using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class PulsingBall : MonoBehaviour
{
    [SerializeField] private float minScale = 0.5f; // Minimum scale of the ball
    [SerializeField] private float maxScale = 2f;   // Maximum scale of the ball
    [SerializeField] private float pulseSpeed = 1f; // Speed of the pulsing effect

    // Update is called once per frame
    void Update()
    {
        // Calculate the new scale using Mathf.PingPong for smooth pulsing effect
        float scale = Mathf.Lerp(minScale, maxScale, Mathf.PingPong(Time.time * pulseSpeed, 1));

        // Apply the new scale to the ball
        transform.localScale = new Vector3(scale, scale, scale);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}

