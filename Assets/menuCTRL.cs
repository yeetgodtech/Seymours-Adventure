using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menuCTRL : MonoBehaviour
{
    // Loads a scene
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Button works!");
    }

    public void exitGame()
    {
        Debug.Log("Exit Button works!");
        Application.Quit();
        
      
    }
}
