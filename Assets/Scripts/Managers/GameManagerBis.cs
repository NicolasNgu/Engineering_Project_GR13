using UnityEngine;

public class GameManagerBis : Singleton<GameManagerBis>
{
    [HideInInspector] 
    public int numGameOver;

    [Header("Codes")]
    public GameObject[] codes;

    [Header("DEMO")]
    public bool isDemo;
    public GameObject[] codesForDemo; 
    
    public void GameOver(int number)
    {
        GameManagerBis.Instance.numGameOver = number;
        AudioManager.Instance.PlayBackgroundMusic(false);
        SceneManagerBis.Instance.ChangeScene("Game Over");
    }

    public void GGEZ()
    {
        bool openTheDoor = true;
        
        foreach (var code in codes)
        {
            if (code.activeSelf == false)
            {
                openTheDoor = false;
            }
        }

        if (openTheDoor)
        {
            
        }
    }
}
