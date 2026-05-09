using UnityEngine;
using UnityEngine.Events;

public class TransformDetector : MonoBehaviour
{
    [Header("Settings")]
    public int frameDelay;

    [Header("Actions")]
    public UnityEvent onMove;
    public UnityEvent onScale;
    public UnityEvent onRotate;

    [Header("State")]
    public bool detect;
    int frameCount = 0;
    Vector3 lastPosition;
    Vector3 lastScale;
    Quaternion lastRotation;

    void Start()
    {
        lastPosition = transform.position;
        lastScale = transform.localScale;
        lastRotation = transform.rotation;
    }

    void Update()
    {
        if (!detect)
        {
            return;
        }
        if (frameCount < frameDelay)
        {
            frameCount++;
            return;
        }
        else
        {
            frameCount = 0;
        }
        if (transform.position != lastPosition)
        {
            lastPosition = transform.position;
            onMove?.Invoke();
        }
        if (transform.localScale != lastScale)
        {
            lastScale = transform.localScale;
            onScale?.Invoke();
        }
        if (transform.rotation != lastRotation)
        {
            lastRotation = transform.rotation;
            onRotate?.Invoke();
        }
    }

    public void StartDetecting()
    {
        detect = true;
        frameCount = 0;
    }

    public void StopDetecting()
    {
        detect = false;
    }

    public void ToggleDetecting()
    {
        detect = !detect;
        if (detect)
        {
            frameCount = 0;
        }
    }
}