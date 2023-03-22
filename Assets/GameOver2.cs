using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver2 : MonoBehaviour
{
    [SerializeField] private GameObject usbKey;

    // Trigger Game Over 2

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == usbKey)
        {

            GameManagerBis.Instance.numGameOver = 2;
            SceneManagerBis.Instance.ChangeScene("Game Over");
        }
    }
}


