using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GoToRoute()
    {
        SceneManager.LoadScene("Game");
    }

    public void GoToDrift()
    {
        SceneManager.LoadScene("DriftSch00l");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
