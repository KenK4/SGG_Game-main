using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int buildIndex;
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
