using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UI : MonoBehaviour
{
    public static UI instance;

    private void Start()
    {
        instance = this;
    }
    public void OnLevelLoaded(string level)
    {
        SceneManager.LoadScene(level);
    }
    public void OnPauseButtonClicked()
    {
        if (Time.timeScale == 0f) 
        {
            Time.timeScale = 1f; 
        }
        else 
        {
            Time.timeScale = 0f; 
        }
    }
    public void OnPauseButtonClickedd()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
       
    }


}
