using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void StartMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void Level1Menu()
    {
        SceneManager.LoadScene(2);
    }
    public void FailMenu()
    {
        SceneManager.LoadScene(6);
    }
    public void PassMenu()
    {
        SceneManager.LoadScene(5);
    }

    public void Shop()
    {
        SceneManager.LoadScene(7);
    }
    public void ExitMenu()
    {
       Application.Quit();
    }
    public void FreeLoad()
    { 
        SceneManager.LoadScene(8);
    }


}
