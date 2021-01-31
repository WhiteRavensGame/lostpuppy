using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void menu()
    {
        SceneManager.LoadScene("UIScene");
    }
    public void gameplay()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void quitgame()
    {
        Application.Quit();
    }
}
