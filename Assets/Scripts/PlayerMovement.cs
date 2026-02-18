using UnityEngine;
using UnityEngine.InputSystem; // 1. Add this namespace

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;

    void FixedUpdate()
    {
        // 2. Use Keyboard.current to check the 'W' key
        if (Keyboard.current.wKey.isPressed)
        {
            // Adding ForceRelative keeps 'forward' relative to where the plane is facing
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
    }
}