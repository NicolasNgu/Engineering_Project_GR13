using UnityEngine;

public class EndGame : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && GameManagerBis.Instance.authorizeExit)
        {
            SceneManagerBis.Instance.ChangeScene("win");
        }
    }
}
