using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void OnStartButton()
    {
        SceneManager.LoadScene("FirstScene");
    }

    public void OnRestartButton()
    {
        SceneManager.LoadScene("FirstScene");
    }

    public void OnExitButton()
    {
        Application.Quit();
    }
}