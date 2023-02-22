using UnityEngine;

public class LockZRotation : MonoBehaviour
{
    private float startingZRotation;

    private void Awake()
    {
        startingZRotation = transform.eulerAngles.z;
    }

    private void LateUpdate()
    {
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z = startingZRotation;
        transform.eulerAngles = newRotation;
    }
}
