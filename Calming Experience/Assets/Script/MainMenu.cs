using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Menu()
    {
        SceneManager.LoadScene(0); //this function sends the user to scene 0 (main menu)
        Cursor.visible = true;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1); //this function sends the user to scene 1 (forest experience)
        Cursor.visible = false;
    }

    public void Settings()
    {
        SceneManager.LoadScene(2); //this function sends the user to scene 2 (settings)
    }

    public void Controls()
    {
        SceneManager.LoadScene(3); //this function sends the user to scene 3 (controls)
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(4); //this function sends the user to scene 4 (quit confirmation)
    }

    public void Quit()
    {
        Application.Quit(); //this function closes the application
    }
}