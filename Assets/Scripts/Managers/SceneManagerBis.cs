using UnityEngine.SceneManagement;

public class SceneManagerBis : Singleton<SceneManagerBis>
{
    public void ChangeScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
