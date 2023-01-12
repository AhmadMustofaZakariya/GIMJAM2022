using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityManagement;
using UnityEngine.SceneManagement;

public class MainMenu_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void UI_Main_Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    void playgame()
    {   
        SceneManager.LoadScene("Gameplay")
    }

    void HowToPlay()
    {
        SceneManager.LoadScene("How to Play")
    }

}
