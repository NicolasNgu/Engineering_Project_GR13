using UnityEngine;

public class GameManagerBis : Singleton<GameManagerBis>
{
    [HideInInspector] public int numGameOver;
    
    public void GameOver(int number)
    {
        GameManagerBis.Instance.numGameOver = number;
        AudioManager.Instance.PlayBackgroundMusic(false);
        SceneManagerBis.Instance.ChangeScene("Game Over");
    }
}
