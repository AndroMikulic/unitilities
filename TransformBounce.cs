using System;
using UnityEngine;
using UnityEngine.Events;
public class TransformBounce : MonoBehaviour
{
    [Header("Settings")]
    public Vector3 targetPosition;
    public float speed = 1f;

    [Header("Actions")]
    [Tooltip("Reference actions you wish to invoke when the transform reaches the target position.")]
    public UnityEvent targetPositionReached;
    [Tooltip("Reference actions you wish to invoke when the transform reaches the starting position again.")]
    public UnityEvent startPositionReached;

    [Header("State")]
    public bool bounce;
    Vector3 originPosition;
    float t = 0f;
    int direction = 1;
    float tSpeed = 0f;

    void Start()
    {
        originPosition = transform.position;
        float distance = Vector3.Distance(originPosition, targetPosition);
        tSpeed = distance > 0f ? speed / distance : 0f;
    }

    void Update()
    {
        if (!bounce)
        {
            return;
        }
        t += Time.deltaTime * tSpeed * direction;
        if (t >= 1)
        {
            t = 1;
            direction = -1;
            targetPositionReached?.Invoke();
        }
        else if (t <= 0f)
        {
            t = 0f;
            direction = 1;
            startPositionReached?.Invoke();
        }

        transform.position = Vector3.Lerp(originPosition, targetPosition, t);
    }

    public void StartBouncing()
    {
        bounce = true;
    }

    public void StopBouncing()
    {
        bounce = false;
    }

    public void ToggleBouncing()
    {
        bounce = !bounce;
    }
}