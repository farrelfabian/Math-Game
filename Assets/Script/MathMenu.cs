using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MathMenu : MonoBehaviour
{
    private int backGame;

    public void BackToGame()
    {
        SceneManager.LoadScene("Map");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void Start() 
    {
        
    }
}