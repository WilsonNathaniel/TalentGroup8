using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour
{
    public void SelectLevel1()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("FirstPlay", 1);
    }
    public void SelectLevel2()
    {
        SceneManager.LoadScene(2);
        PlayerPrefs.SetInt("FirstPlay", 1);
    }
    public void SelectLevel3()
    {
        SceneManager.LoadScene(3);
        PlayerPrefs.SetInt("FirstPlay", 1);
    }
    public void SelectLevel4()
    {
        SceneManager.LoadScene(4);
        PlayerPrefs.SetInt("FirstPlay", 1);
    }
    public void SelectLevel5()
    {
        SceneManager.LoadScene(5);
        PlayerPrefs.SetInt("FirstPlay", 1);
    }
    public void SelectLevel6()
    {
        SceneManager.LoadScene(6);
        PlayerPrefs.SetInt("FirstPlay", 1);
    }
    public void SelectLevel7()
    {
        SceneManager.LoadScene(7);
        PlayerPrefs.SetInt("FirstPlay", 1);
    }
    public void SelectLevel8()
    {
        SceneManager.LoadScene(8);
        PlayerPrefs.SetInt("FirstPlay", 1);
    }
    public void SelectLevel9()
    {
        SceneManager.LoadScene(9);
        PlayerPrefs.SetInt("FirstPlay", 1);
    }
}
