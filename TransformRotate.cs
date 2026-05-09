using UnityEngine;

public class TransformRotate : MonoBehaviour
{
    [Header("Settings")]
    public float xRotationSpeed = 0f;
    public float yRotationSpeed = 0f;
    public float zRotationSpeed = 0f;

    [Header("State")]
    public bool rotate;

    void Update()
    {
        if (!rotate)
        {
            return;
        }
        transform.Rotate(
            xRotationSpeed * Time.deltaTime,
            yRotationSpeed * Time.deltaTime,
            zRotationSpeed * Time.deltaTime,
            Space.Self
        );
    }

    public void StartRotating()
    {
        rotate = true;
    }

    public void StopRotating()
    {
        rotate = false;
    }

    public void ToggleRotation()
    {
        rotate = !rotate;
    }

}
