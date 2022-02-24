using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    private void Start()
    {
        Screen.SetResolution(Screen.height * 4 / 3, Screen.height, true);
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }



}
