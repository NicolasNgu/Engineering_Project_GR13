using UnityEngine;

public class gameOver3 : MonoBehaviour
{
    [SerializeField] private GameObject usbKey;

    // Trigger Game Over 3
    public void initiateGameOver3()
    {
      
        GameManagerBis.Instance.GameOver(3);
        
    }
}


