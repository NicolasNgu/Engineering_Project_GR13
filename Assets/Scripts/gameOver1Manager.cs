using UnityEngine;

public class gameOver1Manager : MonoBehaviour
{
    [SerializeField] private CharacterController player;
    [SerializeField] private computerManager computer;
    

    // Trigger Game Over 1
    void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.name == "XR Origin" && computer.screenIsLit)
        {
            GameManagerBis.Instance.numGameOver = 1;
            SceneManagerBis.Instance.ChangeScene("Game Over");
        }
    }
}
