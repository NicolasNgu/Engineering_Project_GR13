using UnityEngine;

public class GameManagerBis : Singleton<GameManagerBis>
{
    [HideInInspector] public int numGameOver;
    [HideInInspector] public bool authorizeExit = false;

    [Header("DEMO")]
    public bool isDemo;
    
    public void GameOver(int number)
    {
        GameManagerBis.Instance.numGameOver = number;
        AudioManager.Instance.PlayBackgroundMusic(false);
        SceneManagerBis.Instance.ChangeScene("Game Over");
    }
}
