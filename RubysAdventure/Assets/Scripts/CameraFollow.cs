using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // The target that the camera will follow
    public Transform target;

    // The offset from the target
    public Vector3 offset;

    // Smoothness factor for the camera movement
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        // Calculate the desired position with the offset
        Vector3 desiredPosition = target.position + offset;

        // Use Vector3.Lerp to smoothly interpolate between the camera's current position and the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Update the camera's position
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
    }
}