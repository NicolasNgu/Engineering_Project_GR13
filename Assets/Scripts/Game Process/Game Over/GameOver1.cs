using UnityEngine;

public class GameOver1 : MonoBehaviour
{
    [SerializeField] private computerManager computer;

    // Trigger Game Over 1
    void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.name == "XR Origin" && computer.screenIsLit)
        {
            GameManagerBis.Instance.GameOver(1);
        }
    }
}
