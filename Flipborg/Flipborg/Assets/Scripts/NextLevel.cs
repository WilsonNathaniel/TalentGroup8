using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GoNextLevel();
        
        
        
    }
    public void GoNextLevel()
    {
        int numOfScene = SceneManager.sceneCountInBuildSettings - 1;
        if(SceneManager.GetActiveScene().buildIndex == numOfScene)
        {
            SceneManager.LoadScene(0);
        }else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
}
