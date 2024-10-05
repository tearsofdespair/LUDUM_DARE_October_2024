using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class UIInteractions : MonoBehaviour
{
    private GameObject SettingsWindow;

    [Inject]
    public void Construct(GameObject settingsWindow)
    {
        SettingsWindow = settingsWindow;
    }

    public void ShowSettings()
    {
        SettingsWindow.SetActive(true);
    }

    public void CloseSettings()
    {
        SettingsWindow.SetActive(false); 
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
