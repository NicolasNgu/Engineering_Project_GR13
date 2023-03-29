using UnityEngine;

public class GoBackToGame : MonoBehaviour
{
    public void BackToGame()
    {
        SceneManagerBis.Instance.ChangeScene("Scene Nicolas");
    }
}
