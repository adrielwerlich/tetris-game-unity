using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Tetris 1"); // Use the scene name to load it
    }
    public void LoadMainMenuScene()
    {
        // SceneManager.LoadScene("MainMenuScene"); // Use the scene name to load it
        SceneManager.UnloadSceneAsync("Tetris 1");
    }
}
