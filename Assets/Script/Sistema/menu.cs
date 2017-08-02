using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    public string mainGameScene;

    public void StartGame()
    {
        SceneManager.LoadScene("PLATAFORM");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}