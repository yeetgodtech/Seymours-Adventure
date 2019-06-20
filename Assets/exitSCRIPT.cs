using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class exitSCRIPT : MonoBehaviour
{
    // Exits Game
    public void exitGame(string sceneExit)
    {
        Application.Quit();
        Debug.Log("Game has been successfully exited!");
    }

}
