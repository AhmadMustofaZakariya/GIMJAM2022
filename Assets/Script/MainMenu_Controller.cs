using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Controller : MonoBehaviour
{
    public Behaviour canvas;
    // Start is called before the first frame update   
    public void UI_Main_Menu()
    {
        SceneManager.LoadScene("UI_Main_Menu");
    }
    public void playGame()
    {
        SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
    }
    public void credit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void Play()
    {
        canvas.enabled = !canvas.enabled;
    }
    public void Exit()
    {
        Application.Quit();
    }
}
