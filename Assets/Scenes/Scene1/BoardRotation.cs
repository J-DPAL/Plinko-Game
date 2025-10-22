using UnityEngine;

public class BoardRotation : MonoBehaviour
{
    [SerializeField] private Transform disk; // Assign the Disk GameObject
    [SerializeField] private float rotationSpeed = 50f; // Rotation speed
    [SerializeField] private float maxRotation = 30f; // Max rotation limit

    private bool canRotate = false; // If rotation is allowed

    void Start()
    {
        ResetRotationLock(); // Ensure board is locked at the start
    }

    void Update()
    {
        if (!canRotate)
        {
            // Check if the disk is moving
            if (disk.GetComponent<Rigidbody2D>().linearVelocity.magnitude > 0.1f)
            {
                canRotate = true; // Allow rotation after disk is released
            }
            return; // Prevent board rotation while disk is still
        }

        // Get input from arrow keys
        float input = Input.GetAxis("Horizontal"); // Left (-1) | Right (+1)
        if (input != 0)
        {
            RotateBoard(input);
        }
    }

    void RotateBoard(float direction)
    {
        float newRotation = transform.eulerAngles.z - direction * rotationSpeed * Time.deltaTime;

        // Convert angle to -180 to 180 range
        if (newRotation > 180) newRotation -= 360;

        // Clamp rotation between -30 and 30 degrees
        newRotation = Mathf.Clamp(newRotation, -maxRotation, maxRotation);

        // Apply rotation
        transform.rotation = Quaternion.Euler(0, 0, newRotation);
    }

    // Reset board rotation and lock it when a new disk is set active
    public void ResetRotationLock()
    {
        canRotate = false; // Lock board rotation
        transform.rotation = Quaternion.Euler(0, 0, 0); // Reset to original rotation
    }
}
