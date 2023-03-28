using UnityEngine;

public class Compass : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        // Rotate the arrow towards the target
        transform.LookAt(target);
    }
}