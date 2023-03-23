using UnityEngine;

public class GameOver2 : MonoBehaviour
{
    [SerializeField] private GameObject usbKey;

    // Trigger Game Over 2
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == usbKey)
        {
            GameManagerBis.Instance.GameOver(2);
        }
    }
}


