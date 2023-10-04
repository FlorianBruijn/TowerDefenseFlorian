using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void quit()
    {
        EditorApplication.isPlaying = false;

        Application.Quit();
    }

    public void StartGame(int nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
}
