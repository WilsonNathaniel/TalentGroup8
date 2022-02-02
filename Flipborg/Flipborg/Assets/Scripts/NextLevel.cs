using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject NextLevelMenu;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        NextLevelMenu.SetActive(true);
    }
    public void GoNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
