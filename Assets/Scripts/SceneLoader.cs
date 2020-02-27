
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        // determine our present scene
        int intCurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // load next scene
        SceneManager.LoadScene(intCurrentSceneIndex + 1);
    }
    
} // SceneLoader
