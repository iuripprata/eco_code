using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Method to load a scene by its name
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Method to load a scene by its build index
    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    // Method to quit the application
    public void QuitGame()
    {
        Debug.Log("Quit Game"); // This works in the editor for testing
        Application.Quit();    // This works in a built application
    }
}
