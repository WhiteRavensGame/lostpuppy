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
    public void startgame()
    {
        SceneManager.LoadScene("DaytimeForest");
    }
    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void MainMenu()
    {
        //Pending Aproval
        SceneManager.LoadScene("MainMenu");
    }
    public void creditsB()
    {
        //Pending Aproval
        SceneManager.LoadScene("CreditsB");
    }
    public void quitgame()
    {
        Application.Quit();
    }
}
