using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    public InputActionProperty leftActivate;

    [Header("Rays")]
    public GameObject leftTeleportation;
    public GameObject leftRay;
    public GameObject rightRay;

    [Header("Menu UI")]
    public GameObject menu;

    void Update()
    {
        // Enable teleportation when menu is not active and left actuvate button is nearly pressed 
        if (!menu.activeSelf && leftActivate.action.ReadValue<float>() > 0.1f)
        {
            leftTeleportation.SetActive(true);
        }

        else
        {
            leftTeleportation.SetActive(false);
        }

        // Same for the rays
        /*leftRay.SetActive(menu.activeSelf);
        rightRay.SetActive(menu.activeSelf);*/
    }
}
