using UnityEngine;

public class ActivateMenuWindow : MonoBehaviour
{
    public GameObject menuWindow;

    void Update()
    {
        if (Input.GetButtonDown("XRI_Left_MenuButton"))
        {
            menuWindow.SetActive(!menuWindow.activeSelf);
        }
    }
}
