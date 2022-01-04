using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Scene Loaded: " + scene.name);

        switch (scene.name)
        {
            case "Main":
                Debug.Log($"Going to: {CrossSceneVars.server}");
                NetworkManager.instance.Connect(CrossSceneVars.server.ToString());
                // play fade in animation
                return;
            default:
                return;
        }

    }
}
