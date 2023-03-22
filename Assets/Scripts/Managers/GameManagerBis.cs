using UnityEngine;

public class GameManagerBis : Singleton<GameManagerBis>
{
    [HideInInspector] public int numGameOver;

    public string LoadMessage()
    {
        TextAsset textAsset = Resources.Load("game_over_" + numGameOver.ToString() + ".txt") as TextAsset;

        return textAsset.text;
    }
    
}
