using UnityEngine;
using UnityEngine.Events;

namespace Unitilities
{
    public class TransformSmoothFollow : MonoBehaviour
    {
        [Header("References")]
        public Transform target;

        [Header("Settings")]
        public float speed = 1.0f;
        [Tooltip("Anything under this distance will be considered as having arrived at the target's position.")]
        public float distanceThreshold = 0.001f;

        [Header("Events")]
        public UnityEvent onTargetLocationArrived;

        [Header("State")]
        [Tooltip("Is the smooth follow active?")]
        public bool follow;
        bool atTargetLocation;

        void Update()
        {
            if (!follow || target == null)
            {
                return;
            }
            var direction = target.position - transform.position;
            if (direction.sqrMagnitude < distanceThreshold)
            {
                // Just arrived at location.
                if (!atTargetLocation)
                {
                    onTargetLocationArrived?.Invoke();
                }
                atTargetLocation = true;
                return;
            }
            atTargetLocation = false;
            transform.position += speed * Time.deltaTime * direction.normalized;
        }

        public void SetTarget(Transform target)
        {
            this.target = target;
        }

        public void StartFollowing()
        {
            follow = true;
        }

        public void StopFollowing()
        {
            follow = false;
        }

        public void ToggleFollowing()
        {
            follow = !follow;
        }

        public bool IsAtTargetLocation()
        {
            return atTargetLocation;
        }

    }
}