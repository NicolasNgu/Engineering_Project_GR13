using UnityEngine;

public class gameOver1Manager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private computerManager computer;
    

    // Trigger Game Over 1
    void OnTriggerExit() 
    {
        if (computer.screenIsLit)
        {
            GameManagerBis.Instance.numGameOver = 1;
            SceneManagerBis.Instance.ChangeScene("Game Over");
        }
    }
}
