using UnityEngine;

public class LockPosition : MonoBehaviour
{
    public GameObject objectToLock;

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void LateUpdate()
    {
        objectToLock.transform.position = startPosition;
    }
}