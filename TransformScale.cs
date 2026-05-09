using UnityEngine;
using UnityEngine.Events;

public class TransformScale : MonoBehaviour
{
    [Header("Settings")]
    public Vector3 startScale = Vector3.one;
    public Vector3 endScale = Vector3.one * 2f;
    public float speed = 1f;

    [Header("Actions")]
    [Tooltip("Reference actions you wish to invoke when the transform reaches the end scale.")]
    public UnityEvent targetScaleReached;
    [Tooltip("Reference actions you wish to invoke when the transform reaches the start scale again.")]
    public UnityEvent startScaleReached;

    [Header("State")]
    public bool scale;

    float t = 0f;
    int direction = 1;

    void Update()
    {
        if (!scale)
        {
            return;
        }
        t += Time.deltaTime * speed * direction;
        if (t >= 1)
        {
            t = 1;
            direction = -1;
            targetScaleReached?.Invoke();
        }
        else if (t <= 0f)
        {
            t = 0f;
            direction = 1;
            startScaleReached?.Invoke();
        }
        transform.localScale = Vector3.Lerp(startScale, endScale, t);
    }

    public void StartScaling()
    {
        scale = true;
    }

    public void StopScaling()
    {
        scale = false;
    }

    public void ToggleScaling()
    {
        scale = !scale;
    }
}