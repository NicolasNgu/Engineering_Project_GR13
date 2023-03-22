using UnityEngine;

public class gameOver1Manager : MonoBehaviour
{
    [SerializeField] private CharacterController player;
    [SerializeField] private computerManager computer;

    public bool gameOver1;
    
    void Start()
    {
        gameOver1 = false;
    }

    // Trigger Game Over 1
    void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.name == "XR Origin" && computer.screenIsLit)
        {
            GameManagerBis.Instance.numGameOver = 1;
            SceneManagerBis.Instance.ChangeScene("Game Over");
            //gameOver1 = true;

        }
    }
}
