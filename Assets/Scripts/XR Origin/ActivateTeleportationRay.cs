using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject leftTeleportation;
    // public InputActionProperty leftActivate;
    // public InputActionProperty leftCancel; 
    public GameObject leftRay;
    public GameObject rightRay;

    public GameObject menu;

    void Update()
    {
        // bool isLeftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftNormal, out int leftNumber, out bool leftValid); // return true if we hit something
        // leftTeleportation.SetActive(!isLeftRayHovering && leftCancel.action.ReadValue<float>() == 0 && leftActivate.action.ReadValue<float>() > 0.1f);

        // Disable teleportation when menu is enable and vice-versa
        leftTeleportation.SetActive(!menu.activeSelf);

        // Same for the ray
        leftRay.SetActive(menu.activeSelf);
    }
}
